using System;
using System.Collections.Generic;

namespace Fuelling_Tracking_WEB_API.Models;

public partial class FuleStation
{
    public int FuelStationId { get; set; }

    public string FuelStationRegCode { get; set; }

    public string Provition { get; set; }

    public string City { get; set; }

    public string Address { get; set; }

    public int PetrolQuantity { get; set; }

    public int DieselQuantity { get; set; }

    public string Password { get; set; }
}
