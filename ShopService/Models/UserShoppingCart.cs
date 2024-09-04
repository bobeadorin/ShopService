namespace ShopService.Models
{
    public class UserShoppingCart
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public List<Item> CurrentShopingCart { get; set; }
        public List<ShoppingCart> ShoppingCartHistory { get; set; }
    }
}
