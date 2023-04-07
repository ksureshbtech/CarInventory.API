namespace Inventory.API.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }

        public string Make { get; set; }

        public DateTime Year { get; set; }

        public double PurchasedAmount { get; set; }

        public string RegistrationNumber { get; set; } 

        public string Colour { get; set; }

        public double CurrentValue { get; set; }

        public string Status { get; set; }

        public string Notes { get; set; }
       
    }
}
