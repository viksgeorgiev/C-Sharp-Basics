using System.ComponentModel;

namespace Santa_s_Gifts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<int> arrayOfHouses = Console.ReadLine()
                                  .Split(" ")
                                  .Select(int.Parse)
                                  .ToList();
            int position = 0;

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(" ").ToArray();

                string action = command[0];


                if (action == "Forward")
                {
                    int steps = int.Parse(command[1]);
                    position += steps;
                    if (position > arrayOfHouses.Count)
                    {
                        position = position % arrayOfHouses.Count;
                    }

                    arrayOfHouses.RemoveAt(position);

                }
                if (action == "Back")
                {
                    int steps = int.Parse(command[1]);
                    position = Math.Abs(position - steps);
                    if (position > arrayOfHouses.Count)
                    {
                        position = position % arrayOfHouses.Count;
                    }

                    arrayOfHouses.RemoveAt(position);
                }
                if (action == "Gift")
                {
                    int index = int.Parse(command[1]);
                    int houseNumber = int.Parse(command[2]);

                    arrayOfHouses.Insert(index, houseNumber);
                    position = index;
                }
                if (action == "Swap")
                {
                    int firstNumber = int.Parse(command[1]);
                    int secondNumber = int.Parse(command[2]);

                    int indexOfFirst = arrayOfHouses.IndexOf(firstNumber);
                    int indexOfSecond = arrayOfHouses.IndexOf(secondNumber);

                    int tempNumber = arrayOfHouses[indexOfFirst];
                    arrayOfHouses[indexOfFirst] = arrayOfHouses[indexOfSecond];
                    arrayOfHouses[indexOfSecond] = tempNumber;
                }
            }

            Console.WriteLine($"Position: {position}");
            Console.WriteLine(string.Join(", ", arrayOfHouses));
        }
    }
}
