using System.Text;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            foreach (char symbol in input)
            {
                char c = (char)(symbol + 3);
                sb.Append(c);
            }
            Console.WriteLine(sb);
        }
    }
}
