namespace EShop.Domain.Entities
{
    public class Warehouse
    {
        public Guid Id { get; set; }
        public Guid ShopId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public bool IsArchive { get; set; }
        public bool IsDelete { get; set; }
        public Shop Shop { get; set; }
        public List<ProductInventory> ProductInventories { get; set; } = new();
    }
}
