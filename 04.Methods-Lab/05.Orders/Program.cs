
namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            PriceForDRink(drink, quantity);

        }

        private static void PriceForDRink(string drink, double quantity)
        {
            if (drink == "coffee")
            {
                Console.WriteLine($"{quantity * 1.50:F2}");
            }
            else if (drink == "water")
            {
                Console.WriteLine($"{quantity * 1.00:F2}");
            }
            else if (drink == "coke")
            {
                Console.WriteLine($"{quantity * 1.40:F2}");
            }
            else if (drink == "snacks")
            {
                Console.WriteLine($"{quantity * 2.00:F2}");
            }
        }
    }
}
