using HomeDesigner.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDesigner.Builder
{
    public class Room : IProject
    {
        public string Style { get; set; }
        public string Floor { get; set; }
        public string Walls { get; set; }
        public string Ceiling { get; set; }
        public List<Furnitureitem> Furnitures { get; set; }
        public double BasePrice { get; set; }
        
        public double GetTotalPrice()
        {
            double totalPrice = BasePrice;
            foreach (var furniture in Furnitures)
            {
                totalPrice += furniture.Price;
            }
            return totalPrice;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Room: {Style}");
            Console.WriteLine($"Floor: {Floor}");
            Console.WriteLine($"Walls: {Walls}");
            Console.WriteLine($"Ceiling: {Ceiling}");
            Console.WriteLine("Furnitures:");
            foreach (var furniture in Furnitures)
            {
                Console.WriteLine($"- {furniture.Name} ({furniture.Color}): ${furniture.Price}");
            }
            Console.WriteLine($"Total Price: ${GetTotalPrice()}");
        }

        public string GetDescription()
        {
            return $"Room Style: {Style}";
        }

        public double GetCost()
        {
            return GetTotalPrice();
        }
    }
}
