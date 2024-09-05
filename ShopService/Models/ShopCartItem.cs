using System.Text.Json.Serialization;

namespace ShopService.Models
{
    public class ShopCartItem
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public Guid ItemId { get; set; }
        public string? Size { get; set; }
        public int TotalPrice {  get; set; }
    }
}
