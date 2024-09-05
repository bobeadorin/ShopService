using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopService.Models;
using ShopService.SqlShopRepository;

namespace ShopService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {
        private IShopRepository _shopRepository;

        public ShopController(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }


        [HttpGet("/getItems/{category}")]
        public IActionResult GetAllItems(string category)
        {
            var items = _shopRepository.getAllItems(category);

            return Ok(items);
        }


        [HttpGet("/getItemByIdentifier/{id}")]
        public IActionResult GetItemByIdentifier(int id)
        {
            try
            {
                var items = _shopRepository.getItemsByIdentifier(id);
                return Ok(items);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Authorize]
        [HttpPost("/addToCart")]
        public IActionResult AddItemToCart([FromBody] ShopCartItem item )
        {
            var userClaims = User.Claims;
            var userId = userClaims.FirstOrDefault(c => c.Type == "id")?.Value;
            if (userId == null) return Unauthorized();

            _shopRepository.AddItemToCart( item, new Guid(userId));

            return Ok();
        }
    }
}
