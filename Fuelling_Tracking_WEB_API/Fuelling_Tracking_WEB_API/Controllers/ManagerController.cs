using Fuelling_Tracking_WEB_API.BLL;
using Fuelling_Tracking_WEB_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fuelling_Tracking_WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly IConfiguration _config; // Import the _configaration JWT

        public ManagerController(IConfiguration config)
        {
            _config = config;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("manager-login-auth")]
        // manager login station code and password 
        public IActionResult managerLogin(FuleStation fuleStation)
        {
            if (fuleStation == null)
            {
                return Ok("NotFound");
            }
            {
                FuelingDbContext db = new FuelingDbContext();

                var ChackFuelStationLogin = db.FuleStations.Where(x => x.FuelStationRegCode == fuleStation.FuelStationRegCode && x.Password == fuleStation.Password).FirstOrDefault();
                if (ChackFuelStationLogin != null)
                {                 
                    return Ok(new JWTService(_config).GenerateToken(
                                ChackFuelStationLogin.FuelStationRegCode.ToString()
                              ));
                }
                else
                {
                    return Ok("NotFound");
                }
            }
        }

        [HttpPost]
        [Route("cus-req")]
        //[Authorize]
       
        public IActionResult cus_req(fuelStationDataGet fuelStationDataGet)
        {
            if (fuelStationDataGet == null)
            {
                return Ok("NotFound");
            }
            else
            {
                FuelingDbContext db = new FuelingDbContext();

                var FuelStationCode = db.FuleStations.Where(x => x.FuelStationRegCode == fuelStationDataGet.FuelStationRegCode).FirstOrDefault();

                if (FuelStationCode != null)
                {
                    int fuleStationId = FuelStationCode.FuelStationId;

                    var CustomerChek = db.CustomerDetails.Where(x => x.FuelStation == fuleStationId && x.States == fuelStationDataGet.statest ).FirstOrDefault();

                    if (CustomerChek != null)
                    {
                        Cus_List dto = new Cus_List();
                        dto = ManagerBLL.GetNonActiveCustomers(CustomerChek.FuelStation, CustomerChek.States);
                        return Ok(dto.CustomerDetailList);
                    }
                    else
                    {
                        return Ok("NotFound");
                    }
                }
                else
                {
                    return Ok("NotFound");

                }




            }
        }

        [HttpDelete]
        [Route("delete-cus/{Id}")]
        public IActionResult DeleteCustomer(int Id)
        {
            if (Id <= 0)
            {
                return BadRequest("Not a valid customer id");

            }
            else
            {
               
                using (FuelingDbContext db = new FuelingDbContext())
                {
                    var cusId = db.CustomerDetails
                        .Where(x => x.Id == Id)
                        .FirstOrDefault();

                    db.Entry(cusId).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                return Ok("Success");

            }
                        
        }

        [HttpPut]
        [Route("update-active-nonActive-cus")]
        public IActionResult updateCusActiveOrNonActive(CustomerDetail customerDetail)
        {
            if (customerDetail.Id <= 0)
            {
                return BadRequest("Not a valid customer id");

            }
            else
            {

                using (FuelingDbContext db = new FuelingDbContext())
                {
                    var existingCustomer = db.CustomerDetails.Where(x=>x.Id== customerDetail.Id).FirstOrDefault<CustomerDetail>();

                    if (existingCustomer != null)
                    {
                        existingCustomer.States = customerDetail.States;
                        db.SaveChanges();
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                return Ok("Success");

            }



        }

        //List<int> _PetrolStock { get; set; } = new List<int>();
        //List<int> _DiesalStock { get; set; } = new List<int>();

        [HttpPost]
        [Route("manager-fuel-stock")]
        public IActionResult GetPetolStockFuelStation(ManagerFuelStockChack managerFuelStockChack)
        {

            if (managerFuelStockChack == null)
            {
                return BadRequest("NotFound");
            }
            else
            {
                using(FuelingDbContext db = new FuelingDbContext())
                {
                    var FuelStationCode = db.FuleStations.Where(x => x.FuelStationRegCode == managerFuelStockChack.FuelStationCode).FirstOrDefault();

                    if (FuelStationCode != null)
                    {
                        ManagerFuelModelList dto = new ManagerFuelModelList();
                        dto = ManagerBLL.GetFuelStationStock(FuelStationCode.FuelStationId, managerFuelStockChack.FuelType);
                        return Ok(dto.managerFuelModels);
                    }
                    else
                    {
                        return NotFound();
                    }
                    
                   
                   
                }
            }



            //_PetrolStock.AddRange(new int[] {});
            //_DiesalStock.AddRange(new int[] {});





           
    }


    }


}
