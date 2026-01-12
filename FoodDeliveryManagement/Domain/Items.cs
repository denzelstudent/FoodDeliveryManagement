namespace FoodDeliveryManagement.Domain
{
    public class Items : BaseDomainModel
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ItemDescription { get; set; } = string.Empty;
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; } = null!;
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}



