namespace ShopService.Models
{
    public class ShoppingCart
    {
        public Guid Id { get; set; }
        public List<Item> Items { get; set; }
    }
}
