using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    public class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }

        public Demon(string name, int health, double damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
        public override string ToString()
        {
            return $"{Name} - {Health} health, {Damage:F2} damage";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] demons = Regex.Split(Console.ReadLine(), @" *,{1} *").Select(x => x.Trim()).ToArray();

            List<Demon> demonList = new List<Demon>();

            for (int i = 0; i < demons.Length; i++)
            {
                string pattern = @"[^0-9\+\-\*\/\.]";

                int demonHealth = 0;

                foreach (Match match in Regex.Matches(demons[i], pattern))
                {
                    char symbol = char.Parse(match.Value.ToString());
                    demonHealth += symbol;
                }

                pattern = @"-?\d+\.?\d*";

                double damage = 0;

                foreach (Match match in Regex.Matches(demons[i], pattern))
                {
                    damage += double.Parse(match.Value);
                }

                List<char> commandList = new List<char>();

                pattern = @"[\/*]";
                
                foreach (Match match in Regex.Matches(demons[i], pattern))
                {
                    commandList.Add(char.Parse(match.Value));
                }

                for (int j = 0; j < commandList.Count; j++)
                {
                    if (commandList[j] == '*')
                    {
                        damage *= 2;
                    }
                    else if (commandList[j] == '/')
                    {
                        damage /= 2;
                    }
                }

                Demon demon = new Demon(demons[i], demonHealth, damage);

                demonList.Add(demon);
            }

            List<Demon> sortedDemons = demonList.OrderBy(d => d.Name).ToList();

            foreach (var demon in sortedDemons)
            {
                Console.WriteLine(demon.ToString());
            }
        }
    }
}
