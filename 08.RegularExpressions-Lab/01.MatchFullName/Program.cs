using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]{1,} [A-Z][a-z]{1,}\b";

            string input = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(input, pattern);

            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value+ " ");
            }
            Console.WriteLine();
        }
    }
}
