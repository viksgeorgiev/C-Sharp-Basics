
namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1 = int.Parse(Console.ReadLine());
            char operatorInputed = char.Parse(Console.ReadLine());
            double number2 = int.Parse(Console.ReadLine());

            Console.WriteLine(DoMathOperation(number1, number2, operatorInputed));

        }

        public static double DoMathOperation(double number1, double number2, char operatorInputed)
        {
            if (operatorInputed == '+') 
            { 
                return number1 + number2;
            }
            else if (operatorInputed == '-')
            {
                return (number1 - number2);
            }
            else if (operatorInputed == '*')
            {
                return number1 * number2;
            }
            else 
            {
                return number1 / number2;
            }
        }
    }
}
