using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public class SellService
    {
        public List<SellClothesDto> Clothes { get; set; } = new List<SellClothesDto>();
        public void AddClothes(string no, string category, string brand, string size, string color, decimal price)
        {
            int maxId = Clothes.Count > 0 ? Clothes.Max(c => int.Parse(c.Id)) : 0;
            SellClothesDto newClothes = new SellClothesDto
            {
                Id = no,
                Category = category,
                Brand = brand,
                Size = size,
                Color = color,
                Price = price
            };
            Clothes.Add(newClothes);
            Console.WriteLine($"Items added successfully.");
        }
        public void ShowClothes()
        {
            foreach (var items in Clothes)
            {
               Console.WriteLine($"Id: {items.Id}, Category: {items.Category}, Brand: {items.Brand}, Size: {items.Size}, Color: {items.Color}, Price: {items.Price}");
                
            }
        }
    }
}
