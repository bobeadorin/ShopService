using ShopService.Models;

namespace ShopService.SqlShopRepository
{
    public interface IShopRepository
    {
        public List<Item> getAllItems(string category);
        public Item getItemsByIdentifier(int id);
        public void AddItemToCart(ShopCartItem shopingCartItem, Guid userId);
    }
}
