namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= inputNumber; i++)
            {
                int numberToPrint = i * 2 - 1;
                Console.WriteLine(numberToPrint);
                sum += numberToPrint;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
