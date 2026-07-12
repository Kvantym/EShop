namespace EShop.Domain.Entities
{
    public class Delivery
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public string DeliveryMethod { get; set; }// тут треба пошуавть мб є щось готове дл достакви 
        public string TrackingNumber { get; set; }
        public string Address { get; set; }
    }
}
