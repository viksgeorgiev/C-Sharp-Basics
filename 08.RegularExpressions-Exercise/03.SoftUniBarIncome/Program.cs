using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace _03.SoftUniBarIncome
{
    public class Order
    {
        public string Customer { get; set; }
        public string Product { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }

        public Order(string customer, string product, int count, double price)
        {
            Customer = customer;
            Product = product;
            Count = count;
            Price = price;
            Total = price * count;
        }

        public override string ToString()
        {
            return $"{Customer}: {Product} - {Total:F2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"%(?<name>[A-Z][a-z]+)%(?:[^\|$%.]*?)<(?<product>\w+)>(?:[^\|$%.]*?)\|(?<count>\d+)\|(?:[^\|$%.]*?)(?<price>\d+(?:\.\d+)*)\$";
            double totalIncome = 0;

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of shift")
            {

                if (!Regex.IsMatch(input, pattern))
                {
                    continue;
                }


                foreach (Match match in Regex.Matches(input, pattern))
                {
                    string customer = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    Order newOrder = new Order(customer, product, count, price);
                    Console.WriteLine(newOrder.ToString());
                    totalIncome += newOrder.Total;
                }

            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
