namespace Fuelling_Tracking_WEB_API.Models
{
    public class CustomerDetailActiveNonActiveList
    {


        public int Id { get; set; }
        public string NicNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string VehicalRegNumber { get; set; }
        public string vehicalName { get; set; }

        public int? fuelQuantity { get; set; }

        public string fuelName { get; set; }
        public string statest { get; set; }

    }
}
