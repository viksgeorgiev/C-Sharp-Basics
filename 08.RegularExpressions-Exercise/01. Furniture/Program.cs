using System.Text.RegularExpressions;

namespace _01._Furniture
{
    public class Furniture
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }

        public Furniture(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Total = price * quantity;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Furniture> listFurnitures = new List<Furniture>();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "Purchase")
            {
                string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(?:\.\d+)*)!(?<quantity>\d+)\b";

                if (!Regex.IsMatch(input, pattern))
                {
                    continue;
                }


                foreach (Match match in Regex.Matches(input, pattern))
                {
                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    Furniture newFurniture = new Furniture(name, price, quantity);

                    listFurnitures.Add(newFurniture);
                }
            }
            double total = listFurnitures.Sum(f => f.Total);

            Console.WriteLine("Bought furniture:");
            foreach (Furniture furniture in listFurnitures)
            {
                Console.WriteLine(furniture.Name);
            }
            Console.WriteLine($"Total money spend: {total:F2}");
        }

    }
}

