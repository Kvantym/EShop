namespace EShop.Domain.Entities
{
    public class Notifications
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Text { get; set; }
        public bool IsRead { get; set; }
        public DateTimeOffset CreateAt { get; set; }
    }
}
