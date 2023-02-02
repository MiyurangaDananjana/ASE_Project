using System;
using System.Collections.Generic;

namespace Fuelling_Tracking_WEB_API.Models;

public partial class CustomerDetail
{
    public int Id { get; set; }

    public string NicNumber { get; set; }

    public string PhoneNumber { get; set; }

    public string VehicalRegNumber { get; set; }

    public string VehicalChassisNumber { get; set; }

    public int? OtpCode { get; set; }

    public DateTime? OtpSendDate { get; set; }

    public int FuelId { get; set; }

    public int FuelStation { get; set; }

    public int? States { get; set; }

    public DateTime? ActiveDate { get; set; }
}
