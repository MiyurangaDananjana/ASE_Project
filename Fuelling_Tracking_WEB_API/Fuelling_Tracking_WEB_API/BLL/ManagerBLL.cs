using Fuelling_Tracking_WEB_API.DAL;
using Fuelling_Tracking_WEB_API.Models;
using System;

namespace Fuelling_Tracking_WEB_API.BLL
{
    public class ManagerBLL
    {
        internal static ManagerFuelModelList GetFuelStationStock(int fuelStationId, int fuelType)
        {
            ManagerFuelModelList managerFuelModelList= new ManagerFuelModelList();
            managerFuelModelList.managerFuelModels = ManagerDAL.GetFuelStationStock(fuelStationId,fuelType);
            return managerFuelModelList;
        }

        internal static Cus_List GetNonActiveCustomers(int fuelStation, int? states)
        {
            Cus_List dto = new Cus_List();
            dto.CustomerDetailList = ManagerDAL.GetNonActiveList(fuelStation, states);
            return dto;
        }
    }
}
