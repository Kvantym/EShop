using EShop.Domain.Enums;

namespace EShop.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid DeliveryId { get; set; }
        public Status Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new();
        public decimal TotalAmount { get; set; }
        public PromoCode PromoCode {  get; set; }
        public DateTimeOffset CreateAt { get; set; }
        public ReturnRequest ReturnRequest { get; set; }
        public Delivery Delivery { get; set; }
        public User User { get; set; }
    }
}
