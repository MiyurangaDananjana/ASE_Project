
using System.Collections.Generic;

namespace Fuelling_Tracking_WEB_API.Models
{
    public class VehicalTypeListDAO
    {
        public List<VehicalTypeDAO> VehicalTypesList { get; set; }

        public List<FuelStation> fuelStations { get; set; }
    }

    public class VehicalTypeDAO
    {
        public int? VehicalType_Id { get; set; }

        public string Vehical_Name { get; set; }
    }
    public class FuelStation
    {
        public int Id { get; set; }
        public string FuelStationCode { get; set; }
    }
}
