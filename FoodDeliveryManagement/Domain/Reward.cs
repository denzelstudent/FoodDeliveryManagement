namespace FoodDeliveryManagement.Domain
{
    public class Reward : BaseDomainModel
    {
        public string Code { get; set; } = string.Empty;
        public string RewardType { get; set; } = string.Empty;
        public decimal RewardAmount { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
    }
}
