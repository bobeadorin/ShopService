using System.Text.Json.Serialization;

namespace ShopService.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price {  get; set; }
        public string Category { get; set; }
        public int Identifier { get; set; }
        public int Quantity { get; set; }
        public string? Size { get; set; }
    }
}
