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
            var chechRegNumber = db.CustomerDetails.Where(x => x.VehicalRegNumber == customerDetail.VehicalRegNumber).FirstOrDefault();

            if(chechRegNumber != null)
            {

                return NotFound("Already Registered");

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
                dto.States = Convert.ToInt32(1);
                dto.ActiveDate = DateTime.Now;
                VehicalTypeBLL.Save_Customer(dto);
                return Ok("201");
               
            }
            
        }

        [HttpGet]
        [Route("get")]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }
    }
}
