namespace FoodDeliveryManagement.Domain
{
    public class Payment : BaseDomainModel
    {
        public string PaymentMethod { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;
    }
}
