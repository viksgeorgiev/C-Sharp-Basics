namespace _02.AMinerTask
{
    public class Resources
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public Resources(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{Name} -> {Quantity}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, Resources> resources = new Dictionary<string, Resources>();

            while ((input = Console.ReadLine()) != "stop")
            {
                string inputName = input;
                int inputQuantity = int.Parse(Console.ReadLine());

                Resources resource = new Resources(inputName, inputQuantity);

                if (!resources.ContainsKey(inputName))
                {
                    resources.Add(inputName, resource);
                }
                else
                {
                    resources[inputName].Quantity += inputQuantity;
                }
            }

            foreach (var pair in resources.Values) 
            {
                Console.WriteLine(pair);
            }
            
        }
    }
}
