namespace EShop.Domain.Entities
{
    public class PromoCode
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public decimal Discount { get; set; }
        public bool IsPercent { get; set; }
        public DateTimeOffset ValidFrom { get; set; }
        public DateTimeOffset ValidTo { get; set; }
    }
}
