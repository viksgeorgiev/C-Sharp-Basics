namespace _03.Orders
{
    public class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public int Quantity { get; set; }

        public Products(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{Name} -> {(Price * Quantity):F2}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, Products> productsDictionary = new Dictionary<string, Products>();

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] inputProduct = input.Split(" ").ToArray();

                string productName = inputProduct[0];
                double productPrice = double.Parse(inputProduct[1]);
                int productQuantity = int.Parse(inputProduct[2]);

                Products product = new Products(productName, productPrice, productQuantity);

                if (!productsDictionary.ContainsKey(productName)) 
                {
                    productsDictionary.Add(productName, product);
                }
                else
                {
                    productsDictionary[productName].Price = productPrice;
                    productsDictionary[productName].Quantity += productQuantity;
                }

            }

            foreach (var product in productsDictionary.Values)
            {
                Console.WriteLine(product);
            }
        }
    }
}
