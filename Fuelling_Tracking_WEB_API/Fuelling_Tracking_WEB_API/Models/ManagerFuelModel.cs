using System.Collections.Generic;

namespace Fuelling_Tracking_WEB_API.Models
{
    public class ManagerFuelModel
    {
        public string _FuelName { get; set; }

 
        public List<int> _FuelStock { get; set; }
    }

    public class ManagerFuelModelList
    {

        //public List<CustomerDetailActiveNonActiveList> CustomerDetailList { get; set; }
        public List<ManagerFuelModel> managerFuelModels { get; set; }
    }
}
