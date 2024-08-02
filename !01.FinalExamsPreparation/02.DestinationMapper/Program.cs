
using System.Text.RegularExpressions;

namespace _02.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([=/])([A-Z][a-zA-Z]{2,})\1";
            List<string> output = new List<string>();
            int travelPoints = 0;

            foreach (Match match in Regex.Matches(input, pattern))
            {
                output.Add(match.Groups[2].Value);
                travelPoints += match.Groups[2].Value.Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", output)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
