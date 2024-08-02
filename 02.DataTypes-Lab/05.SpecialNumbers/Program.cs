using System.Diagnostics.CodeAnalysis;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberRange = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberRange; i++)
            {
                int num = i;
                int sum = 0;
                

                while (num != 0)
                {
                    sum += num % 10;
                    num /= 10;
                }

                if (sum == 5 || sum == 7|| sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
