using ShopService.DbConnection;
using ShopService.Models;

namespace ShopService.SqlShopRepository
{
    public class ShopRepository: IShopRepository
    {
        private AppDbContext _dbContext;

        public ShopRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<Item> getAllItems(string category)
        {
            List<Item> items;
            if(category == "*")
            {
                items = _dbContext.Items.ToList();
            }else
            {
                items = _dbContext.Items.Where(i => i.Category == category).ToList();
            }

            return items;
        }

        public Item getItemsByIdentifier(int id)
        {
            var item = _dbContext.Items.FirstOrDefault(i => i.Identifier == id) ;

            if (item == null) throw new Exception("The item was not found");

          return item;
        }

        public void AddItemToCart(ShopCartItem shopingCartItem, Guid userId)
        {
            var user = _dbContext.UserShoppingCart.FirstOrDefault(u => u.UserId == userId);

            if (user == null)
            {
                _dbContext.UserShoppingCart.Add(new UserShoppingCart
                {
                    UserId = userId,
                    ShopingCart = new List<ShopCartItem> { shopingCartItem }
                });
                _dbContext.SaveChanges();
            }
            else
            {
                user.ShopingCart.Add(shopingCartItem);



                _dbContext.SaveChanges();

            }
        }

    }
}
