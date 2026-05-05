using System;
using System.IO;

namespace HomeDesigner.Adapter
{
    public class FileLoggerAdapter : IProjectLogger
    {
        private readonly string _filePath;

        public FileLoggerAdapter(string filePath)
        {
            _filePath = filePath;
        }

        public void LogProject(string description, double originalPrice, double finalPrice)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_filePath, true))
                {
                    writer.WriteLine($"--- New saving: {DateTime.Now} ---");
                    writer.WriteLine($"Project: {description}");
                    writer.WriteLine($"Original price: {originalPrice:F2} BGN");
                    writer.WriteLine($"Final price (after discounts): {finalPrice:F2} BGN");
                    writer.WriteLine(new string('-', 30));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while logging through Adapter: {ex.Message}");
            }
        }
    }
}