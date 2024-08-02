using System.Security.AccessControl;

namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());

            int[] field = new int[sizeOfField];

            int[] ladyBugsIndexes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            foreach (var index in ladyBugsIndexes)
            {
                if (index >= 0 && index < sizeOfField)
                {
                    field[index] = 1;
                }
            }

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split(" ").ToArray();

                int indexOfBug = int.Parse(commands[0]);
                string direction = commands[1];
                int flyLength = int.Parse(commands[2]);

                if (indexOfBug < 0 || indexOfBug >= sizeOfField || field[indexOfBug] != 1)
                {
                    continue;
                }

                field[indexOfBug] = 0;


                while (true)
                {
                    if (direction == "right")
                    {
                        indexOfBug += flyLength;
                    }
                    else if (direction == "left")
                    {
                        indexOfBug -= flyLength;
                    }

                    if (indexOfBug < 0 || indexOfBug >= sizeOfField)
                    {
                        break;
                    }

                    if (field[indexOfBug] == 0)
                    {
                        field[indexOfBug] = 1;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
