using HomeDesigner.Builder;
using HomeDesigner.Decorator;
using HomeDesigner.Strategy;

namespace HomeDesigner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DesignerDirector designer = new DesignerDirector();
            ScandinavianRoomBuilder scandinavianBuilder = new ScandinavianRoomBuilder();

            designer.Construct(scandinavianBuilder);

            Room scandinavianRoom = scandinavianBuilder.GetResult();
            Console.WriteLine("Scandinavian Room:");
            scandinavianRoom.DisplayInfo();

            IProject project = scandinavianRoom;
            project.GetDescription();
            project = new _3DDecorator(project);

            Console.WriteLine();
            Console.WriteLine("Adding 3D visualization.");

            IPaymentStrategy payment = new VipDiscountStrategy();
            Console.WriteLine();
            double discountedAmount = payment.Discount(project.GetCost());



            string path = "project_info.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine("==================================");
                    writer.WriteLine("---FINAL OFFER---");
                    writer.WriteLine($"Project: {project.GetDescription()}");
                    writer.WriteLine($"Total cost: ${project.GetCost():F2}.");
                    writer.WriteLine($"Type: VIP (15% discount)");
                    writer.WriteLine($"FINAL AMOUNT TO PAY: ${discountedAmount:F2}.");
                    Console.WriteLine("==================================");

                    Console.WriteLine("File is saved successfully.");
                }
            }      
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
            Console.WriteLine("==================================");
            Console.WriteLine("---FINAL OFFER---");
            Console.WriteLine($"Project: {project.GetDescription()}");
            Console.WriteLine($"Total cost: ${project.GetCost():F2}.");
            Console.WriteLine($"Type: VIP (15% discount)");
            Console.WriteLine($"FINAL AMOUNT TO PAY: ${discountedAmount:F2}.");
            Console.WriteLine("==================================");
        }
    }
}
