using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace _02.Race
{
    public class Race
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Race(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Race> dictRace = new Dictionary<string, Race>();

            string[] racers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (string racer in racers)
            {
                dictRace.Add(racer, new Race(racer, 0));
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of race")
            {
                string pattern = @"[A-Za-z]";

                StringBuilder sb = new StringBuilder();

                foreach (Match match in Regex.Matches(input, pattern))
                {
                    sb.Append(match.Value);
                }
                string racerName = sb.ToString();

                pattern = @"\d";

                int distance = 0;
                foreach (Match match in Regex.Matches(input, pattern))
                {
                    distance += int.Parse(match.Value);
                }

                if (dictRace.ContainsKey(racerName))
                {
                    dictRace[racerName].Value += distance;
                }
            }

            List<Race> listOfTheFirst = dictRace.Values
                                                .OrderByDescending(x => x.Value)
                                                .Take(3)
                                                .ToList();

            Console.WriteLine($"1st place: {listOfTheFirst[0].Name}");
            Console.WriteLine($"2nd place: {listOfTheFirst[1].Name}");
            Console.WriteLine($"3rd place: {listOfTheFirst[2].Name}");
        }
    }
}
