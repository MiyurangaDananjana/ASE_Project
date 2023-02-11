using System.Collections.Generic;

namespace Fuelling_Tracking_WEB_API.Models
{
    public class FuelStock
    {
        public string Id { get; set; }
        public int available { get; set; }

        public int finished { get; set; }
    }
    public class ManagerFuelStockChack
    {
        public string FuelStationCode { get; set; }
        public int FuelType { get; set; }

      
    }

    public class FuelStockList
    {
        public List<FuelStock> Stocks { get; set; }
    }


}
