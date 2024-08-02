namespace G00.Santa_sNewList
{
    public class SantaList
    {
        public Dictionary<string, Children> Children { get; set; }
        public Dictionary<string, Toys> Toys { get; set; }
        public SantaList()
        {
            Children = new Dictionary<string, Children>();
            Toys = new Dictionary<string, Toys>();
        }
    }
    public class Children
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public Children(string name, int amount)
        {
            Name = name;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"{Name} -> {Amount}";
        }
    }
    public class Toys
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public Toys(string name, int amount)
        {
            Name = name;
            Amount = amount;
        }
        public override string ToString()
        {
            return $"{Name} -> {Amount}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            SantaList santaList = new SantaList();

            while ((input = Console.ReadLine()) != "END")
            {
                string[] inputData = input.Split("->").ToArray();

                if (inputData[0] == "Remove")
                {
                    string childsName = inputData[1];
                    santaList.Children.Remove(childsName);
                }
                else
                {
                    string childsName = inputData[0];
                    string toyName = inputData[1];
                    int amount = int.Parse(inputData[2]);

                    if (santaList.Children.ContainsKey(childsName))
                    {
                        santaList.Children[childsName].Amount += amount;
                    }
                    else
                    {
                        Children newChild = new Children(childsName, amount);
                        santaList.Children.Add(childsName, newChild);
                        
                    }
                    if (santaList.Toys.ContainsKey(toyName))
                    {
                        santaList.Toys[toyName].Amount += amount;
                    }
                    else
                    {
                        Toys newToy = new Toys(toyName, amount);
                        santaList.Toys.Add(toyName, newToy);
                    }
                }
            }

            Dictionary<string, Children> listToPrint = santaList.Children
                                            .OrderByDescending(ch => ch.Value.Amount)
                                            .ThenBy(ch => ch.Value.Name)
                                            .ToDictionary(ch => ch.Key, ch => ch.Value);

            Console.WriteLine("Children:");
            foreach (Children child in listToPrint.Values)
            {
                Console.WriteLine(child);
            }
            Console.WriteLine("Presents:");
            foreach (Toys toy in santaList.Toys.Values)
            {
                Console.WriteLine(toy);
            }

        }
    }
}
