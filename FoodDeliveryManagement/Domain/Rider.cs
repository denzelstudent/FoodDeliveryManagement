namespace FoodDeliveryManagement.Domain
{
    public class Rider : BaseDomainModel
    {
        public string Name { get; set; } = string.Empty;
        public string VehicleType { get; set; } = string.Empty;
        public string Contacts { get; set; } = string.Empty;
        public string AvailabilityStatus { get; set; } = string.Empty;
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}

