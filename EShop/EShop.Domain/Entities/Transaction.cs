using EShop.Domain.Enums;

namespace EShop.Domain.Entities
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public StatusAmount StatusAmount { get; set; }//тут може тоже є щото готовке
        public string PaymentProvider { get; set; }//тут може тоже є щото готовке
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
