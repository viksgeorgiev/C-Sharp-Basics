using System.Security.Cryptography;

namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    AddNumbers(numberOne, numberTwo);
                    break;
                case "multiply":
                    MultiplyNumbers(numberOne, numberTwo);
                    break;
                case "subtract":
                    SubstractNumbers(numberOne, numberTwo);
                    break;
                case "divide":
                    DivideNumbers(numberOne, numberTwo);
                    break;
            }
        }

        private static void DivideNumbers(double numberOne, double numberTwo)
        {
            Console.WriteLine(numberOne / numberTwo);
        }

        private static void SubstractNumbers(double numberOne, double numberTwo)
        {
            Console.WriteLine(numberOne - numberTwo);
        }

        private static void MultiplyNumbers(double numberOne, double numberTwo)
        {
            Console.WriteLine(numberOne * numberTwo);
        }

        private static void AddNumbers(double numberOne, double numberTwo)
        {
            Console.WriteLine(numberOne + numberTwo);
        }
    }
}
