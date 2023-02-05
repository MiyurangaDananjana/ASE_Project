using System.Collections.Generic;

namespace Fuelling_Tracking_WEB_API.Models
{
    public class FuelStock
    {
      
        public int available { get; set; }

        public int finished { get; set; }
    }

    public class FuelStockList
    {
        public List<FuelStock> Stocks { get; set; }
    }


}
