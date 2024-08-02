using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    public class Message
    {
        public string PlanetName { get; set; }
        public int Population { get; set; }
        public string AttackType { get; set; }
        public int SoldierCount { get; set; }

        public Message(string planetName, int population, string attackType, int soldierCount)
        {
            PlanetName = planetName;
            Population = population;
            AttackType = attackType;
            SoldierCount = soldierCount;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());

            List<Message> messages = new List<Message>();

            for (int i = 0; i < numberOfMessages; i++)
            {
                string message = Console.ReadLine();

                string pattern = @"[STARstar]";
                StringBuilder sb = new StringBuilder();

                foreach (char letter in message)
                {
                    sb.Append((char)(letter - Regex.Matches(message, pattern).Count));
                }

                string shiftedMessage = sb.ToString();

                pattern = @"@(?<planet>[A-Za-z]+)(?:[^\@\-\!\:\>])*?:(?:[^\@\-\!\:\>])*?(?<population>\d+)(?:[^\@\-\!\:\>])*?!(?<attack>[A|D])!(?:[^\@\-\!\:\>])*?->(?:[^\@\-\!\:\>])*?(?<soldiers>\d+)";

                foreach (Match match in Regex.Matches(shiftedMessage, pattern))
                {
                    string planetName = match.Groups["planet"].Value;
                    int population = int.Parse(match.Groups["population"].Value);
                    string attackType = match.Groups["attack"].Value;
                    int soldiers = int.Parse(match.Groups["soldiers"].Value);

                    Message newMessage = new Message(planetName, population, attackType, soldiers);

                    messages.Add(newMessage);
                }
            }
            List<Message> attackedPlanets = messages.Where(p => p.AttackType == "A").OrderBy(p => p.PlanetName).ToList();
            List<Message> destroyedPlanets = messages.Where(p => p.AttackType == "D").OrderBy(p => p.PlanetName).ToList();

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach(var planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet.PlanetName}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets)
            {
                Console.WriteLine($"-> {planet.PlanetName}");
            }
        }
    }
}
