namespace EShop.Domain.Entities
{
    public class Promotion
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public float DiscountPercentage { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
    }
}
