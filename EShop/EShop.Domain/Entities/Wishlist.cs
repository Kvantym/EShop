namespace EShop.Domain.Entities
{
    public class Wishlist
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public User User { get; set; }
    }
}
