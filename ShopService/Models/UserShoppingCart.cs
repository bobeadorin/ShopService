namespace ShopService.Models
{
    public class UserShoppingCart
    {   
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public List<ShopCartItem> ShopingCart { get; set; }
    }
}
