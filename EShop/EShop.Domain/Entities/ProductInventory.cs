namespace EShop.Domain.Entities
{
    public class ProductInventory
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public Guid WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; } = null!;
        public Product Product { get; set; }
    }
}
