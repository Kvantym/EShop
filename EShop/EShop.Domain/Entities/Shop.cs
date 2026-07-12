namespace EShop.Domain.Entities
{
    public class Shop
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public float Rating { get; set; }
        public List<Product> Products { get; set; }
        public List<Warehouse> Warehouses { get; set; }
        public User User { get; set; }

    }
}
