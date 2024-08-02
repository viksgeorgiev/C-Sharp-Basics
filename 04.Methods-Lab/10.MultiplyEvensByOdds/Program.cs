namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = Math.Abs(int.Parse(Console.ReadLine()));

            int sumEven = GetSumOfEvenDigits(inputNumber);
            int sumOdd = GetSumOfOddDigits(inputNumber);
            Console.WriteLine(GetMultipleOfEvenAndOdds(sumEven, sumOdd));
        }

        private static int GetMultipleOfEvenAndOdds(int sumEven, int sumOdd)
        {
            return sumEven * sumOdd;
        }

        private static int GetSumOfOddDigits(int inputNumber)
        {
            int sum = 0;
            foreach (char digit in inputNumber.ToString())
            {
                if (int.Parse(digit.ToString()) % 2 == 1)
                {
                    sum += int.Parse(digit.ToString());
                }
            }
            return sum;
        }

        private static int GetSumOfEvenDigits(int inputNumber)
        {
            int sum = 0;
            foreach (char digit in inputNumber.ToString())
            {
                if (int.Parse(digit.ToString()) % 2 == 0)
                {
                    sum += int.Parse(digit.ToString());
                }                  
            }
            return sum;
        }
    }
}
