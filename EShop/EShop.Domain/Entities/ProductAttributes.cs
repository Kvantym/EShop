namespace EShop.Domain.Entities
{
    public class ProductAttributes
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid DescriptionId { get; set; }
        public List<Image> Images { get; set; }
        public Description Description { get; set; }
        public Product Product { get; set; } = null!;
    }
}
