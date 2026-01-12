namespace FoodDeliveryManagement.Domain
{
    public class Customer : BaseDomainModel
    {
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Contacts { get; set; } = string.Empty;
        public string PaymentInformation { get; set; } = string.Empty;
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<Reward> Rewards { get; set; } = new List<Reward>();
    }
}

