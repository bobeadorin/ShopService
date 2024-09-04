namespace ShopService.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price {  get; set; }
        public string Category { get; set; }
    }
}
