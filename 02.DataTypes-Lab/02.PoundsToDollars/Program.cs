namespace _02.PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 British Pound = 1.31 Dollars

            double pounds = double.Parse(Console.ReadLine());

            Console.WriteLine($"{(pounds*1.31):F3}");
        }
    }
}
