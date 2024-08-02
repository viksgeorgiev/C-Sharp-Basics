using System.Text;

namespace _02.AsciiSumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            List<char> list = Console.ReadLine().Where(c => (c > firstChar && c < secondChar)).ToList();

            Console.WriteLine(list.Sum(c => c));
        }
    }
}
