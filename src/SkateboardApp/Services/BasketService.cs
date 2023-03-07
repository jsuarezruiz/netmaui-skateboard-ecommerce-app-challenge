using SkateboardApp.Models;

namespace SkateboardApp.Services
{
    public class BasketService
    {
        public IEnumerable<BasketItem> GetBasket()
        {
            return new List<BasketItem>
            {
                new BasketItem { ProductId = 1, ProductName = "Pinky Panther Skateboard", ProductColor = Colors.Pink, ProductImage = "skate01.png", UnitPrice = 85, },
                new BasketItem { ProductId = 2, ProductName = "Garfied Extraction Series - Volume 2", ProductColor = Colors.Aquamarine, ProductImage = "skate02.png", UnitPrice = 80, },
                new BasketItem { ProductId = 3, ProductName = "Dead Pez Skateboard", ProductColor = Colors.Black, ProductImage = "skate03.png", UnitPrice = 70, },
                new BasketItem { ProductId = 4, ProductName = "The Gorf Skateboard", ProductColor = Colors.Yellow, ProductImage = "skate04.png", UnitPrice = 70, },
                new BasketItem { ProductId = 5, ProductName = "The Incredible Skunk Skateboard", ProductColor = Colors.LightGreen, ProductImage = "skate05.png", UnitPrice = 75, },
            };
        }
    }
}