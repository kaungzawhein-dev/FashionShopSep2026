using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class BuyService
    {
        public static List<BuyClothesDto> Clothes { get; set; } = new List<BuyClothesDto>();
        public void AddClothes(string category, string brand, string size, string color, decimal price, decimal quantity)
        {
            
            BuyClothesDto newClothes = new BuyClothesDto
            {
                Category = category,
                Brand = brand,
                Size = size,
                Color = color,
                Price = price,
                quantity = quantity
            };
            Clothes.Add(newClothes);
            Console.WriteLine($"Items bought successfully.");
        }
        public void ShowClothes()
        {
            foreach (var items in Clothes)
            {
                Console.WriteLine($"Category: {items.Category}, Brand: {items.Brand}, Size: {items.Size}, Color: {items.Color}, Price: {items.Price}");

            }
        }
    }
}
