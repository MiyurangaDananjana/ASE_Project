using Fuelling_Tracking_WEB_API.BLL;
using Fuelling_Tracking_WEB_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Fuelling_Tracking_WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewCustomerController : ControllerBase
    {
        enum CustomerStates
        {
            NoneActive,
            ManagerApproved,
        }


        [HttpGet]
        [Route("GetVehical")]
        public IActionResult VehicalGet()
        {
            try
            {
                VehicalTypeListDAO dto = new VehicalTypeListDAO();
                dto = VehicalTypeBLL.GetVehicalTypeAndId();
                return Ok(dto.VehicalTypesList);
            }
            catch (System.Exception)
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Route("Fuel-Station")]
        public IActionResult Fuel_Station()
        {
            try
            {
                VehicalTypeListDAO dto = new VehicalTypeListDAO();
                dto = VehicalTypeBLL.Get_Fuel_Station();
                return Ok(dto.fuelStations);
            }
            catch (System.Exception)
            {

                return NotFound();
            }
        }

        [HttpPost]
        [Route("Req-customer")]
        public IActionResult CustomerSave(CustomerDetail customerDetail)
        {

            FuelingDbContext db = new FuelingDbContext();
            var chechRegNumber = db.CustomerDetails.Where(x => x.VehicalRegNumber == customerDetail.VehicalRegNumber && x.PhoneNumber == customerDetail.PhoneNumber).FirstOrDefault();

            if (chechRegNumber != null)
            {

                return Ok("415");

            }
            else
            {

                CustomerDetail dto = new CustomerDetail();
                dto.NicNumber = customerDetail.NicNumber;
                dto.PhoneNumber = customerDetail.PhoneNumber;
                dto.VehicalRegNumber = customerDetail.VehicalRegNumber;
                dto.VehicalChassisNumber = customerDetail.VehicalChassisNumber;
                dto.FuelId = customerDetail.FuelId;
                dto.FuelStation = customerDetail.FuelStation;
                dto.States = Convert.ToInt32(0); // Account is non activated states
                dto.ActiveDate = DateTime.Now;
                VehicalTypeBLL.Save_Customer(dto);
                return Ok("201");

            }

        }

        [HttpPost]
        [Route("sent-otp")]
        public IActionResult customerLoginCheck(CustomerDetail customerDetail)
        {
            FuelingDbContext db = new FuelingDbContext();

            int customerStatus = (int)CustomerStates.ManagerApproved;


            var chackPhoneNumber = db.CustomerDetails.Where(x => x.PhoneNumber == customerDetail.PhoneNumber && x.States == customerStatus).FirstOrDefault();

            if (chackPhoneNumber != null)
            {
                VehicalTypeBLL otpSend = new VehicalTypeBLL();
                int _rendomOtpCode = GenerateRandomNo();
                string cusMassage = $"Fuel Pass: Ontime validation (OTP) {_rendomOtpCode} Expire in 5 minutes"; // Message Template 
                //otpSend.messageSend(chackPhoneNumber.PhoneNumber, cusMassage); 



                //Update Otp send date and time
                CustomerDetail cussetail = new CustomerDetail();
                cussetail.PhoneNumber = customerDetail.PhoneNumber;
                cussetail.OtpCode = _rendomOtpCode;
                cussetail.OtpSendDate = DateTime.Now;
                VehicalTypeBLL.UpdateOtpSendDateTime(cussetail);
                return Ok("201");
            }
            else
            {
                return Ok("NotReg");
               

            }

        }

        //Generate The Random OTP Code 
        public static int GenerateRandomNo()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }
    }
}
