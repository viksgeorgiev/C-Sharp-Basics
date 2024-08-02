namespace D03.P_rates
{
    public class Cities
    {
        public string CityNames { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
        public Cities(string cityNames, int population, int gold)
        {
            CityNames = cityNames;
            Population = population;
            Gold = gold;
        }

        public override string ToString()
        {
            return $"{CityNames} -> Population: {Population} citizens, Gold: {Gold} kg";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Dictionary<string, Cities> dictCities = new Dictionary<string, Cities>();

            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] inputData = input.Split("||").ToArray();

                string cityName = inputData[0];
                int population = int.Parse(inputData[1]);
                int gold = int.Parse(inputData[2]);

                if (dictCities.Keys.Contains(cityName))
                {
                    dictCities[cityName].Population += population;
                    dictCities[cityName].Gold += gold;
                }
                else
                {
                    Cities newCity = new Cities(cityName, population, gold);
                    dictCities.Add(cityName, newCity);
                }
            }

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split("=>").ToArray();

                string command = commands[0];

                if (command == "Plunder")
                {
                    string cityName = commands[1];
                    int people = int.Parse(commands[2]);
                    int gold = int.Parse(commands[3]);

                    dictCities[cityName].Population -= people;
                    dictCities[cityName].Gold -= gold;
                    Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (dictCities[cityName].Population == 0 || dictCities[cityName].Gold == 0)
                    {
                        Console.WriteLine($"{cityName} has been wiped off the map!");
                        dictCities.Remove(cityName);
                    }
                }

                if (command == "Prosper")
                {
                    string cityName = commands[1];
                    int gold = int.Parse(commands[2]);

                    if(gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        dictCities[cityName].Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {cityName} now has {dictCities[cityName].Gold} gold.");
                    }
                }

            }
            if (dictCities.Keys.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {dictCities.Keys.Count} wealthy settlements to go to:");
                foreach (Cities city in dictCities.Values)
                {
                    Console.WriteLine(city);
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
