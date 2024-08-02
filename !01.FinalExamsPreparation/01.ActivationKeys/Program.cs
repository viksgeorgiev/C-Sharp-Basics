using System.Text;

namespace D01.ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();

            StringBuilder stringBuilderKey = new StringBuilder(rawActivationKey);

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] instructions = input.Split(">>>").ToArray();

                string command = instructions[0];

                if (command == "Contains")
                {
                    string substring = instructions[1];
                    if (stringBuilderKey.ToString().Contains(substring))
                    {
                        Console.WriteLine($"{stringBuilderKey.ToString()} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                if (command == "Flip")
                {
                    string caseToDo = instructions[1];
                    int startIndex = int.Parse(instructions[2]);
                    int endIndex = int.Parse(instructions[3]);

                    if (caseToDo == "Upper")
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            stringBuilderKey[i] = char.Parse(stringBuilderKey[i].ToString().ToUpper());
                        }
                        Console.WriteLine(stringBuilderKey.ToString());
                    }
                    else if (caseToDo == "Lower")
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            stringBuilderKey[i] = char.Parse(stringBuilderKey[i].ToString().ToLower());
                        }
                        Console.WriteLine(stringBuilderKey.ToString());
                    }
                }
                if (command == "Slice")
                {
                    int startIndex = int.Parse(instructions[1]);
                    int endIndex = int.Parse(instructions[2]);

                    stringBuilderKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(stringBuilderKey.ToString());
                }
            }
            Console.WriteLine($"Your activation key is: {stringBuilderKey.ToString()}");
        }
    }
}
