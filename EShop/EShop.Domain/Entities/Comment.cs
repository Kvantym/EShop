namespace EShop.Domain.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
        public string Title { get; set; }
        public int Raiting { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
