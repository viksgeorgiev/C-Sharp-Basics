namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringsInput = Console.ReadLine().Split(" ").ToArray();
            
            Array.Reverse(stringsInput);

            Console.WriteLine(string.Join(" ", stringsInput));
        }
    }
}
