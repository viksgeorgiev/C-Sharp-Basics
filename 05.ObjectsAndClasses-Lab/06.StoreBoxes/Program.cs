using System.Runtime.CompilerServices;

namespace _06.StoreBoxes
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
    public class Box
    {
        
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceBox { get; set; }

        public Box(string serialNumber, Item item, int quantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            Quantity = quantity;
            PriceBox = quantity * item.Price;
        }
        public override string ToString()
        {
            return $"{SerialNumber}\n-- {Item.Name} - ${Item.Price:F2}: {Quantity}\n-- ${PriceBox:F2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            List<Box> boxes = new List<Box>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] itemsData = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string serialNumber = itemsData[0];
                string itemName = itemsData[1];
                int quantity = int.Parse(itemsData[2]);
                decimal itemPrice = decimal.Parse(itemsData[3]);

                Item item = new Item(itemName,itemPrice);
                Box newBox = new Box(serialNumber,item,quantity);
                boxes.Add(newBox);
            }

            List<Box> orderedBoxes = boxes.OrderByDescending(i => i.PriceBox).ToList();

            foreach (Box box in orderedBoxes) 
            {
                Console.WriteLine(box.ToString());
            }
        }
    }
}
