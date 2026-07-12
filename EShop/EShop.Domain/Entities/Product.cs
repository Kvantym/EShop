namespace EShop.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public Guid ProductInventoryId { get; set; }
        public Guid PromotionId { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public bool IsArchive { get; set; }
        public bool IsDelete { get; set; }
        public List<Comment> Comments { get; set; }
        public ProductInventory ProductInventory { get; set; }
        public Promotion? Promotion { get; set; }
        public ProductAttributes ProductAttributes { get; set; } = null!;
        public List<Category> Categories { get; set; }
    }
}
