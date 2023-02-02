using System;
using System.Collections.Generic;

namespace Fuelling_Tracking_WEB_API.Models;

public partial class VehicalType
{
    public int VehicalTypeId { get; set; }

    public string VehicalName { get; set; }

    public int? Fuelquantity { get; set; }

    public int? FuelTypeId { get; set; }
}
