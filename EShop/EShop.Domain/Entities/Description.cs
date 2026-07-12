namespace EShop.Domain.Entities
{
    public class Description
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
