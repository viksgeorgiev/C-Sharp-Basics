namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] doubles = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            foreach (double number in doubles)
            {
                Console.WriteLine($"{number} => {Convert.ToDecimal(Math.Round(number, MidpointRounding.AwayFromZero))}");
            }
        }
    }
}
//double roundedValueOdd = Math.Round(originalValue, MidpointRounding.AwayFromZero);