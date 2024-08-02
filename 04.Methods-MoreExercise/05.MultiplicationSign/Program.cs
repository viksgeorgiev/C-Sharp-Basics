

namespace _05.MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            if (IsZero(num1, num2, num3))
            {
                Console.WriteLine("zero");
            }
            else if (IsNegative(num1, num2, num3))
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }

        }

        static bool IsZero(int num1, int num2, int num3)
        {
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsNegative(int num1, int num2, int num3)
        {
            int negativeCounter = 0;

            if (num1 < 0)
            {
                negativeCounter++;
            }
            if (num2 < 0)
            {
                negativeCounter++;
            }
            if (num3 < 0)
            {
                negativeCounter++;
            }

            if (negativeCounter % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
