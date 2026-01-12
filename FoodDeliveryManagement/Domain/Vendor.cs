namespace FoodDeliveryManagement.Domain
{
    public class Vendor : BaseDomainModel
    {
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Contacts { get; set; } = string.Empty;
        public string OperatingHours { get; set; } = string.Empty;

        public ICollection<Items> Items { get; set; } = new List<Items>();
    }
}


