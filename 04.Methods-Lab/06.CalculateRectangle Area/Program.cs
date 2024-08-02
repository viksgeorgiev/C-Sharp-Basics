
namespace _06.CalculateRectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(CalcualateAreaOfRectangle(side, height));
        }

        public static double CalcualateAreaOfRectangle(double side, double height)
        {
            return (side * height);
        }
    }
}
