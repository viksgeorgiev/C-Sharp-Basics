

namespace _01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int givenInteger = int.Parse(Console.ReadLine());

            CheckSign(givenInteger);
        }

        private static void CheckSign(int givenInteger)
        {
            if (givenInteger > 0)
            {
                Console.WriteLine($"The number {givenInteger} is positive. ");
            }
            else if (givenInteger < 0)
            {
                Console.WriteLine($"The number {givenInteger} is negative. ");
            }
            else if (givenInteger == 0)
            {
                Console.WriteLine($"The number {givenInteger} is zero. ");
            }
        }
    }
}
