using System.Security.Claims;
using System.Security.Cryptography;

namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(baseNumber, power));
        }

        private static double MathPower(double baseNumber, double power)
        {
            if (power == 0) 
            {
                return 1;
            }
            double times = power;
            double result = baseNumber;
            for (int i = 1; i < power; i++)
            {
                result *= baseNumber;
                times--;
            }
            return result;
        }
    }
}
