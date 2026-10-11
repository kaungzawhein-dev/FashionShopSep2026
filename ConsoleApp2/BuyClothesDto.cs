using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class BuyClothesDto
    {
        public string Category { get; set; }
        public string Brand { get; set; }

        public string Size { get; set; }

        public string Color { get; set; }

        public decimal Price { get; set; }

        public decimal quantity { get; set; }
    }
}
