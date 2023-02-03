using Fuelling_Tracking_WEB_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fuelling_Tracking_WEB_API.DAL
{
    public class CustomerDAL : _context
    {
        public static List<VehicalTypeDAO> Get_Vehical_Detail()
        {
            FuelingDbContext db = new FuelingDbContext();

            List<VehicalTypeDAO> vehical_detail = new List<VehicalTypeDAO>();
            var list = from VehicalDetail in db.VehicalTypes
                       select new
                       {
                           ID = VehicalDetail.VehicalTypeId,
                           Name = VehicalDetail.VehicalName
                       };
            foreach (var item in list)
            {
                VehicalTypeDAO dto = new VehicalTypeDAO();
                dto.VehicalType_Id = item.ID;
                dto.Vehical_Name = item.Name;
                vehical_detail.Add(dto);
            }
            return vehical_detail;
        }
        internal static List<FuelStation> Get_FuelStation_Detail()
        {
            FuelingDbContext db = new FuelingDbContext();

            List<FuelStation> _station = new List<FuelStation>();
            var list = from fuelStation in db.FuleStations
                       select new
                       {
                           id = fuelStation.FuelStationId,
                           FuelStationReg = fuelStation.FuelStationRegCode

                       };
            foreach (var item in list)
            {
                FuelStation dto = new FuelStation();
                dto.Id = item.id;
                dto.FuelStationCode = item.FuelStationReg;
                _station.Add(dto);
            }
            return _station;
        }
        internal static void Save_Customer(CustomerDetail dto)
        {
            FuelingDbContext db = new FuelingDbContext();
            db.CustomerDetails.Add(dto);
            db.SaveChanges();

        }


        internal static void UpdateOtpSendDateTime(CustomerDetail cussetail)
        {
            FuelingDbContext db = new FuelingDbContext();
            CustomerDetail PhoneNumber = db.CustomerDetails.FirstOrDefault(x=>x.PhoneNumber == cussetail.PhoneNumber);
            PhoneNumber.OtpCode= cussetail.OtpCode;
            PhoneNumber.OtpSendDate = cussetail.OtpSendDate;
            db.SaveChanges();


        }
    }
}
