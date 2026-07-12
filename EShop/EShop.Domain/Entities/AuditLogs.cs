namespace EShop.Domain.Entities
{
    public class AuditLogs
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Action { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
