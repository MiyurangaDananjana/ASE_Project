using Fuelling_Tracking_WEB_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Types;

namespace Fuelling_Tracking_WEB_API.DAL
{
    public class ManagerDAL
    {
        internal static List<CustomerDetailActiveNonActiveList> GetNonActiveList(int fuelStation, int? states)
        {
            FuelingDbContext db = new FuelingDbContext();
            List<CustomerDetailActiveNonActiveList> customerDetails = new List<CustomerDetailActiveNonActiveList>();
            var list = (from customer in db.CustomerDetails
                        where customer.FuelStation == fuelStation && customer.States == states
                        join vehicalName in db.VehicalTypes on customer.FuelId equals vehicalName.VehicalTypeId
                        join statest in db.Statests on customer.States equals statest.Id
                        join fuelType in db.FuelTypes on vehicalName.FuelTypeId equals fuelType.Fueid
                        select new
                        {
                            tbId = customer.Id,
                            nicNumber = customer.NicNumber,
                            phoneNumber = customer.PhoneNumber,
                            vehicalRegNumber = customer.VehicalRegNumber,
                            vehicalName = vehicalName.VehicalName,
                            fuelTypeName = fuelType.FuelType1,
                            fuelQuantity = vehicalName.Fuelquantity,
                            statest = statest.Name
                        });
            foreach (var item in list)
            {
                CustomerDetailActiveNonActiveList dto = new CustomerDetailActiveNonActiveList();
                dto.Id = item.tbId;
                dto.NicNumber = item.nicNumber;
                dto.PhoneNumber = item.phoneNumber;
                dto.VehicalRegNumber = item.vehicalRegNumber;
                dto.vehicalName = item.vehicalName;
                dto.fuelQuantity = item.fuelQuantity;
                dto.fuelName = item.fuelTypeName;
                dto.statest = item.statest;
                customerDetails.Add(dto);
            }
            return customerDetails;
        }

    }
}
