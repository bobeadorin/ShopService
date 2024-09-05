using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopService.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Identifier = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserShoppingCart",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserShoppingCart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShopCartItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPrice = table.Column<int>(type: "int", nullable: false),
                    UserShoppingCartId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopCartItem_UserShoppingCart_UserShoppingCartId",
                        column: x => x.UserShoppingCartId,
                        principalTable: "UserShoppingCart",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Category", "Description", "Identifier", "Price", "Quantity", "Size", "Title" },
                values: new object[,]
                {
                    { new Guid("0c9a2531-d7ed-4af1-8273-61751f98f7e5"), "tshirt", "Hop into good vibes with the Lucky Frog T-Shirt! This shirt features a cheerful, bright-green frog sitting on a lily pad, bringing a splash of luck and a dash of charm to your day. Made from ultra-soft, high-quality cotton, it’s the perfect blend of comfort and whimsy. Whether you’re feeling lucky or just love a fun, froggy design, the Lucky Frog T-Shirt is a must-have addition to your wardrobe. Wear it, and let your good fortune leap to new heights!", 3, 10, 0, null, "Lucky Frog T-shirt" },
                    { new Guid("22554dd6-f6e1-4051-a496-47193e3b99a0"), "painting", "Blast off into a vibrant cosmos with the \"Funky Asteroids\" painting, where space meets surrealism in a burst of color and imagination. This dynamic artwork features a swirling galaxy of brightly colored asteroids, each with its own unique pattern and shape, dancing across a cosmic backdrop. The bold, funky hues contrast beautifully with the dark, star-speckled sky, creating a sense of movement and energy that pulls you into its orbit. Perfect for those who love a mix of whimsy and the wonders of outer space, \"Funky Asteroids\" adds a lively and adventurous vibe to any room, making your walls a portal to a universe of creativity.", 7, 35, 0, null, "Funky Asteroids" },
                    { new Guid("349d1581-7d43-4f05-a9fe-1720396a14a1"), "tshirt", "Get ready for laughs with the Knock on It T-Shirt! This clever design gives a playful nod to the classic \"knock-knock\" jokes we all love. Featuring a cheeky door graphic and the phrase “Knock on It” in bold, eye-catching letters, this shirt is perfect for anyone who enjoys a good punchline. Made from soft, durable cotton, it's as comfortable as it is amusing. Whether you're cracking jokes or just love a fun, conversation-starting tee, the Knock on It T-Shirt is sure to bring a smile to everyone you meet.", 4, 10, 0, null, "Knock  on It T-shirt" },
                    { new Guid("4c06b620-3380-4584-98d7-35b53624ec00"), "tshirt", "Unleash your playful side with our Monkey Graphic T-Shirt. Made from soft, breathable fabric, this tee features a vibrant and whimsical monkey design that adds a fun twist to your casual wear. Whether you’re hanging out with friends or going on an adventure, this monkey t-shirt is sure to make a statement. Express your unique style and love for animals with this eye-catching piece!”", 1, 10, 0, null, "Monkey T-shirt" },
                    { new Guid("66cf1b73-e09f-4aca-8fcd-0c4110ce39ca"), "painting", "Experience the serene beauty of nature with the \"Flowers in the Wind\" painting. This captivating artwork captures the delicate dance of vibrant flowers swaying in a gentle breeze, evoking a sense of peace and tranquility. The vivid colors and flowing brushstrokes bring the scene to life, making you feel as if you can almost hear the rustling petals and feel the soft wind. Perfect for adding a touch of elegance and calm to any space, \"Flowers in the Wind\" is an ideal piece for those who appreciate the simple yet profound beauty of nature.", 5, 45, 0, null, "Flowers in the wind" },
                    { new Guid("6eafc0e2-bf71-400f-ac17-5d7aaa38f169"), "painting", "Step into an ethereal garden with the \"Ghost Flowers\" painting, where delicate blooms seem to drift between the realms of the living and the spectral. This hauntingly beautiful artwork features translucent flowers that appear to glow with an otherworldly light, their soft, pale hues blending seamlessly with the misty, dreamlike background. The painting's mysterious ambiance and subtle details create a captivating, almost surreal experience, making it a striking piece for anyone drawn to the beauty of the unknown. \"Ghost Flowers\" is perfect for adding a touch of mystique and elegance to your space, where the boundaries between reality and fantasy gently blur.", 6, 35, 0, null, "Ghost flowers" },
                    { new Guid("731e12ef-1307-41f5-bfa7-062b808d4ebb"), "tshirt", "Top off your outfit with a twist of humor with the Joke Hat T-Shirt! This quirky tee features a fun illustration of a classic hat with a hilarious twist—because why should hats have all the fun? Made from soft, comfortable cotton, this shirt is perfect for those who love a good laugh and aren’t afraid to wear their sense of humor on their sleeve. Whether you're a fan of puns or just enjoy a good joke, the Joke Hat T-Shirt is the perfect way to share your playful spirit wherever you go.", 9, 10, 0, null, "Joke Hat T-Shirt" },
                    { new Guid("7b553502-7991-40f7-aa9a-0d69831b427d"), "plate", "Serve up a side of humor with the KnockKnock Plate! This playful dish features a fun design inspired by classic \"knock-knock\" jokes, with a clever door motif at its center. Perfect for adding a dash of whimsy to your meals, this plate is made from durable, high-quality ceramic, making it both functional and amusing. Whether you're hosting a dinner party or just enjoying a snack, the KnockKnock Plate is sure to be a conversation starter and a delightful addition to your tableware collection. Knock, knock—who's there? Your new favorite plate!", 8, 3, 0, null, "Knock Knock" },
                    { new Guid("a709286f-77a2-43b0-a939-aa6dddb111b6"), "tshirt", "Dive into the deep end of your wardrobe with the Funky Whale T-Shirt! Featuring a playful, vibrant whale graphic that’s sure to make waves, this shirt is perfect for anyone with a sense of humor as big as the ocean. Made from soft, breathable cotton, it’s as comfortable as it is quirky. Whether you’re lounging at home, hitting the beach, or just making a splash around town, the Funky Whale T-Shirt is your go-to for fun, casual style. Get yours and let your outfit be the catch of the day!", 2, 10, 0, null, "Funky Whale T-shirt" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopCartItem_UserShoppingCartId",
                table: "ShopCartItem",
                column: "UserShoppingCartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "ShopCartItem");

            migrationBuilder.DropTable(
                name: "UserShoppingCart");
        }
    }
}
