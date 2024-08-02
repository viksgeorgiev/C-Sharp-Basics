using System.Security.Principal;

namespace _03PlantDiscovery
{
    public class Plants
    {
        public string Name { get; set; }


        public int Rarity { get; set; }
        public List<double> Rating { get; set; }

        public Plants(string name, int rarity)
        {
            Name = name;
            Rarity = rarity;
            Rating = new List<double>();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPlants = int.Parse(Console.ReadLine());

            Dictionary<string,Plants> plants = new Dictionary<string,Plants>();

            for (int i = 0;i< numberOfPlants; i++)
            {
                string[] plantInformation = Console.ReadLine().Split("<->").ToArray();
                string plantName = plantInformation[0];
                int plantRarity = int.Parse(plantInformation[1]);

                Plants newPlant = new Plants(plantName,plantRarity);   
                plants.Add(plantName,newPlant);
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Exhibition")
            {
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!plants.ContainsKey(commands[1]))
                {
                    Console.WriteLine("error");
                    continue;
                }

                if (commands[0] == "Rate:")
                {
                    string plant = commands[1];
                    double rating = double.Parse(commands[3]);
                    plants[plant].Rating.Add(rating);
                }
                if (commands[0] == "Update:")
                {
                    string plant = commands[1];
                    int newRarity = int.Parse(commands[3]);
                    plants[plant].Rarity = newRarity;
                }
                if (commands[0] == "Reset:")
                {
                    string plant = commands[1];
                    plants[plant].Rating.Clear();
                }
            }


            Console.WriteLine("Plants for the exhibition:");
            foreach (Plants plant in plants.Values) 
            {
                Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {AvgRating(plant):F2}");
            }



            double AvgRating(Plants plant)
            {
                if (plant.Rating.Count > 0)
                {
                    return plant.Rating.Average();
                }
                else
                {
                    return 0.0;
                }
            }
        }
    }
}
