namespace EShop.Domain.Entities
{
    public class Basket
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public List<BasketItem> Items { get; set; } = new List<BasketItem>();
    }
}
