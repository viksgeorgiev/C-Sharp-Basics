namespace _03.HeroesÒfCodeAndLogicVII
{
    public class Heroes
    {
        public string HeroName { get; set; }
        public int HitPoints { get; set; }
        public int ManaPoints { get; set; }
        public Heroes(string heroName, int hitPoints, int manaPoints)
        {
            HeroName = heroName;
            HitPoints = hitPoints;
            ManaPoints = manaPoints;
        }
        public override string ToString()
        {
            return $"{HeroName}\n  HP: {HitPoints}\n  MP: {ManaPoints}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());

            Dictionary<string, Heroes> dictOfHeroes = new Dictionary<string, Heroes>();

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] heroesInput = Console.ReadLine().Split(" ").ToArray();

                string heroName = heroesInput[0];
                int hitPoints = int.Parse(heroesInput[1]);
                int manaPoints = int.Parse(heroesInput[2]);

                Heroes newHero = new Heroes(heroName, hitPoints, manaPoints);
                dictOfHeroes.Add(heroName, newHero);
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split(" - ").ToArray();

                string command = commands[0];
                string heroName = commands[1];

                if (command == "CastSpell")
                {
                    int mpNeeded = int.Parse(commands[2]);
                    string spellName = commands[3];

                    if (dictOfHeroes[heroName].ManaPoints - mpNeeded >= 0)
                    {
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {dictOfHeroes[heroName].ManaPoints - mpNeeded} MP!");
                        dictOfHeroes[heroName].ManaPoints -= mpNeeded;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                if (command == "TakeDamage")
                {
                    int damage = int.Parse(commands[2]);
                    string attacker = commands[3];

                    if (dictOfHeroes[heroName].HitPoints - damage > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {dictOfHeroes[heroName].HitPoints - damage} HP left!");
                        dictOfHeroes[heroName].HitPoints -= damage;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        dictOfHeroes.Remove(heroName);
                    }
                }
                if (command == "Recharge")
                {
                    int amount = int.Parse(commands[2]);

                    if (dictOfHeroes[heroName].ManaPoints + amount <= 200)
                    {
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                        dictOfHeroes[heroName].ManaPoints += amount;
                    }
                    else
                    {
                        int amountRecovered = amount;
                        amountRecovered -= ((dictOfHeroes[heroName].ManaPoints + amount) - 200);
                        Console.WriteLine($"{heroName} recharged for {amountRecovered} MP!");
                        dictOfHeroes[heroName].ManaPoints = 200;
                    }
                }
                if (command == "Heal")
                {
                    int amount = int.Parse(commands[2]);

                    if (dictOfHeroes[heroName].HitPoints + amount <= 100)
                    {
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                        dictOfHeroes[heroName].HitPoints += amount;
                    }
                    else
                    {
                        int amountRecovered = amount;
                        amountRecovered -= ((dictOfHeroes[heroName].HitPoints + amount) - 100);
                        Console.WriteLine($"{heroName} healed for {amountRecovered} HP!");
                        dictOfHeroes[heroName].HitPoints = 100;
                    }
                }

            }
            foreach (Heroes heroes in dictOfHeroes.Values)
            {
                Console.WriteLine(heroes.ToString());
            }
        }
    }
}
