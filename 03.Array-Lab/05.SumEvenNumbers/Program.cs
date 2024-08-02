namespace _05.SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sum = input.Where(x => x % 2== 0).Sum();           
            Console.WriteLine(sum);
        }
    }
}
