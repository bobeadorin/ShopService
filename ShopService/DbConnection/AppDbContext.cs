using Microsoft.EntityFrameworkCore;
using ShopService.Models;

namespace ShopService.DbConnection
{
    public class AppDbContext : DbContext
    {
        public IConfiguration _config { get; set; }

        public AppDbContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                    new Item
                    {
                        Id = Guid.NewGuid(),
                        Title = "Monkey T-shirt",
                        Description = "Unleash your playful side with our Monkey Graphic T-Shirt. Made from soft, breathable fabric, this tee features a vibrant and whimsical monkey design that adds a fun twist to your casual wear. Whether you’re hanging out with friends or going on an adventure, this monkey t-shirt is sure to make a statement. Express your unique style and love for animals with this eye-catching piece!”",
                        Price = 10,
                        Category = "tshirt",
                        Identifier = 1,
                    },
                     new Item
                     {
                         Id = Guid.NewGuid(),
                         Title = "Funky Whale T-shirt",
                         Description = "Dive into the deep end of your wardrobe with the Funky Whale T-Shirt! Featuring a playful, vibrant whale graphic that’s sure to make waves, this shirt is perfect for anyone with a sense of humor as big as the ocean. Made from soft, breathable cotton, it’s as comfortable as it is quirky. Whether you’re lounging at home, hitting the beach, or just making a splash around town, the Funky Whale T-Shirt is your go-to for fun, casual style. Get yours and let your outfit be the catch of the day!",
                         Price = 10,
                         Category = "tshirt",
                         Identifier = 2,
                     },
                       new Item
                       {    
                           Id = Guid.NewGuid(),
                           Title = "Lucky Frog T-shirt",
                           Description = "Hop into good vibes with the Lucky Frog T-Shirt! This shirt features a cheerful, bright-green frog sitting on a lily pad, bringing a splash of luck and a dash of charm to your day. Made from ultra-soft, high-quality cotton, it’s the perfect blend of comfort and whimsy. Whether you’re feeling lucky or just love a fun, froggy design, the Lucky Frog T-Shirt is a must-have addition to your wardrobe. Wear it, and let your good fortune leap to new heights!",
                           Price = 10,
                           Category = "tshirt",
                            Identifier = 3,
                       },
                       new Item
                       {
                           Id = Guid.NewGuid(),
                           Title = "Knock  on It T-shirt",
                           Description = "Get ready for laughs with the Knock on It T-Shirt! This clever design gives a playful nod to the classic \"knock-knock\" jokes we all love. Featuring a cheeky door graphic and the phrase “Knock on It” in bold, eye-catching letters, this shirt is perfect for anyone who enjoys a good punchline. Made from soft, durable cotton, it's as comfortable as it is amusing. Whether you're cracking jokes or just love a fun, conversation-starting tee, the Knock on It T-Shirt is sure to bring a smile to everyone you meet.",
                           Price = 10,
                           Category = "tshirt",
                           Identifier = 4,
                       },    
                         new Item
                         {
                             Id = Guid.NewGuid(),
                             Title = "Flowers in the wind",
                             Description = "Experience the serene beauty of nature with the \"Flowers in the Wind\" painting. This captivating artwork captures the delicate dance of vibrant flowers swaying in a gentle breeze, evoking a sense of peace and tranquility. The vivid colors and flowing brushstrokes bring the scene to life, making you feel as if you can almost hear the rustling petals and feel the soft wind. Perfect for adding a touch of elegance and calm to any space, \"Flowers in the Wind\" is an ideal piece for those who appreciate the simple yet profound beauty of nature.",
                             Price = 45,
                             Category = "painting",
                             Identifier = 5,
                         },
                        new Item
                        {
                            Id = Guid.NewGuid(),
                            Title = "Ghost flowers",
                            Description = "Step into an ethereal garden with the \"Ghost Flowers\" painting, where delicate blooms seem to drift between the realms of the living and the spectral. This hauntingly beautiful artwork features translucent flowers that appear to glow with an otherworldly light, their soft, pale hues blending seamlessly with the misty, dreamlike background. The painting's mysterious ambiance and subtle details create a captivating, almost surreal experience, making it a striking piece for anyone drawn to the beauty of the unknown. \"Ghost Flowers\" is perfect for adding a touch of mystique and elegance to your space, where the boundaries between reality and fantasy gently blur.",
                            Price = 35,
                            Category = "painting",
                            Identifier = 6,
                        },
                        new Item
                        {
                            Id = Guid.NewGuid(),
                            Title = "Funky Asteroids",
                            Description = "Blast off into a vibrant cosmos with the \"Funky Asteroids\" painting, where space meets surrealism in a burst of color and imagination. This dynamic artwork features a swirling galaxy of brightly colored asteroids, each with its own unique pattern and shape, dancing across a cosmic backdrop. The bold, funky hues contrast beautifully with the dark, star-speckled sky, creating a sense of movement and energy that pulls you into its orbit. Perfect for those who love a mix of whimsy and the wonders of outer space, \"Funky Asteroids\" adds a lively and adventurous vibe to any room, making your walls a portal to a universe of creativity.",
                            Price = 35,
                            Category = "painting",
                            Identifier = 7,
                        },
                        new Item
                        {
                            Id = Guid.NewGuid(),
                            Title = "Knock Knock",
                            Description = "Serve up a side of humor with the KnockKnock Plate! This playful dish features a fun design inspired by classic \"knock-knock\" jokes, with a clever door motif at its center. Perfect for adding a dash of whimsy to your meals, this plate is made from durable, high-quality ceramic, making it both functional and amusing. Whether you're hosting a dinner party or just enjoying a snack, the KnockKnock Plate is sure to be a conversation starter and a delightful addition to your tableware collection. Knock, knock—who's there? Your new favorite plate!",
                            Price = 3,
                            Category = "plate",
                            Identifier = 8,
                        },
                         new Item
                         {
                             Id = Guid.NewGuid(),
                             Title = "Joke Hat T-Shirt",
                             Description = "Top off your outfit with a twist of humor with the Joke Hat T-Shirt! This quirky tee features a fun illustration of a classic hat with a hilarious twist—because why should hats have all the fun? Made from soft, comfortable cotton, this shirt is perfect for those who love a good laugh and aren’t afraid to wear their sense of humor on their sleeve. Whether you're a fan of puns or just enjoy a good joke, the Joke Hat T-Shirt is the perfect way to share your playful spirit wherever you go.",
                             Price = 10,
                             Category = "tshirt",
                             Identifier = 9,
                         }
                    );
        }

       public DbSet<Item> Items { get; set; }
       public DbSet<UserShoppingCart> UserShoppingCart { get; set; }  
    }
}
