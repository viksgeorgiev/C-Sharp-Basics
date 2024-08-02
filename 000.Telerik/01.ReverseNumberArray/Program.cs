using System.Text;

namespace _01.ReverseNumberArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] stringArray = input.ToCharArray();

            Array.Reverse(stringArray);
            
            Console.WriteLine(string.Join("", stringArray));
        }
    }
}
