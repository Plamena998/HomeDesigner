using System;
using HomeDesigner.Adapter;
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

            IRoomBuilder builder = new ScandinavianRoomBuilder();
            // IRoomBuilder builder = new IndustrialRoomBuilder();
            // IRoomBuilder builder = new VintageRoomBuilder();

            designer.Construct(builder);
            Room room = builder.GetResult();

            Console.WriteLine($"{room.Style} Room:");
            room.DisplayInfo();

            IProject project = room;
            project = new _3DDecorator(project);

            Console.WriteLine();
            Console.WriteLine("Adding 3D visualization.");

            double baseCostWithExtras = project.GetCost();

            IPaymentStrategy payment = new VipDiscountStrategy();
            Console.WriteLine();
            double discountedAmount = payment.Discount(baseCostWithExtras);

            IProjectLogger logger = new FileLoggerAdapter("project_info.txt");
            logger.LogProject(project.GetDescription(), baseCostWithExtras, discountedAmount);
            logger = new ConsoleLoggerAdapter();
            logger.LogProject(project.GetDescription(), baseCostWithExtras, discountedAmount);

            //Console.WriteLine("==================================");
            //Console.WriteLine("---FINAL OFFER---");
            //Console.WriteLine($"Project: {project.GetDescription()}");
            //Console.WriteLine($"Total cost: ${baseCostWithExtras:F2}.");
            //Console.WriteLine($"Type: VIP (15% discount)");
            //Console.WriteLine($"FINAL AMOUNT TO PAY: ${discountedAmount:F2}.");
            //Console.WriteLine("==================================");
            //Console.WriteLine("Project is saved successfully via Adapter.");
            //Console.WriteLine("==================================");

        }
    }
}