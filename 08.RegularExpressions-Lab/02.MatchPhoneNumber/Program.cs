using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( |\-)2\1\d{3}\1\d{4}\b";

            string input = Console.ReadLine();

            List<string> sofiaNumbers = new List<string>();
            
            foreach (Match number in Regex.Matches(input, pattern))
            {
                sofiaNumbers.Add(number.Value);
            }

            Console.WriteLine(string.Join(", ", sofiaNumbers));
        }
    }
}
