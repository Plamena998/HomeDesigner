using System;

namespace HomeDesigner.Adapter
{
    public class ConsoleLoggerAdapter : IProjectLogger
    {
        public void LogProject(string description, double originalPrice, double finalPrice)
        {
            Console.WriteLine("\n[LOG SYSTEM - CONSOLE ADAPTER]");
            Console.WriteLine(new string('~', 40));
            Console.WriteLine($"RUNTIME: {DateTime.Now}");
            Console.WriteLine($"PROJECT: {description}");
            Console.WriteLine($"BASE PRICE: ${originalPrice:F2}");
            Console.WriteLine($"TYPE: VIP (15% discount)");
            Console.WriteLine($"FINAL PRICE: ${finalPrice:F2}");
            Console.WriteLine(new string('~', 40));
        }
    }
}