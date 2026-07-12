using EShop.Domain.Enums;

namespace EShop.Domain.Entities
{
    public class ReturnRequest
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Reason Reason { get; set; }
        public DateTimeOffset RequestDate { get; set; }
        public string ReturnTrackingNumber { get; set; }
        public RefundStatus RefundStatus { get; set; }
        public ConditionStatus ConditionStatus { get; set; }
        public Order Order { get; set; }
    }
}
