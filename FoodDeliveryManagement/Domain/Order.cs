namespace FoodDeliveryManagement.Domain
{
    public class Order : BaseDomainModel
    {
        public string OrderStatus { get; set; } = string.Empty;
        public DateTime OrderTime { get; set; }
        public string OrderLocation { get; set; } = string.Empty;
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public int? RiderId { get; set; }
        public Rider? Rider { get; set; }
        public Payment? Payment { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}


