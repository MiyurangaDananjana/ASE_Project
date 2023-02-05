using System;
using System.Collections.Generic;

namespace Fuelling_Tracking_WEB_API.Models;

public partial class FuelStationStock
{
    public int FSSId { get; set; }

    public int FSId { get; set; }

    public int FTId { get; set; }

    public int MainStock { get; set; }

    public int AvailableStock { get; set; }
}
