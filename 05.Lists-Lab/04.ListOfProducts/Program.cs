

namespace _04.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int productsNumber = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();

            FillList(products, productsNumber);
            PrintList(products);
            
        }

        private static void PrintList(List<string> products)
        {
            foreach (string product in products)
            {
                Console.WriteLine($"{products.IndexOf(product) + 1}.{product}");
            }
        }

        private static void FillList(List<string> products, int productsNumber)
        {
            for (int i = 0; i < productsNumber; i++)
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();
        }
    }
}
