using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDesigner.Builder
{
    public class Furnitureitem
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        public Furnitureitem(string name, string color, double price)
        {
            Name = name;
            Color = color;
            Price = price;
        }
    }
}
