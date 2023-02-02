using Fuelling_Tracking_WEB_API.DAL;
using Fuelling_Tracking_WEB_API.Models;
using System;

namespace Fuelling_Tracking_WEB_API.BLL
{
    public class VehicalTypeBLL
    {
        internal static VehicalTypeListDAO GetVehicalTypeAndId()
        {
           VehicalTypeListDAO dto = new VehicalTypeListDAO();
            dto.VehicalTypesList = CustomerDAL.Get_Vehical_Detail();
            return (dto);
        }

        internal static VehicalTypeListDAO Get_Fuel_Station()
        {
            VehicalTypeListDAO dto = new VehicalTypeListDAO();
            dto.fuelStations = CustomerDAL.Get_FuelStation_Detail();
            return (dto);
        }

        internal static void Save_Customer(CustomerDetail dto)
        {
            CustomerDAL.Save_Customer(dto);
        }
    }
}
