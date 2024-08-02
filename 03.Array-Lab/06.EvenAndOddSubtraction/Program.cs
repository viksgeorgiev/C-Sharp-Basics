namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sumEven = input.Where(x => x % 2 == 0).Sum();
            int sumOdd = input.Where(y => y % 2 == 1).Sum();
            Console.WriteLine(sumEven-sumOdd);
        }
    }
}
