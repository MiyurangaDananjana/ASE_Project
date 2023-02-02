using System;
using System.Collections.Generic;

namespace Fuelling_Tracking_WEB_API.Models;

public partial class FuelReq
{
    public int Id { get; set; }

    public int? FuelStationId { get; set; }

    public int? FuelType { get; set; }

    public int? Quantity { get; set; }

    public int? States { get; set; }

    public DateTime? DateTime { get; set; }
}
