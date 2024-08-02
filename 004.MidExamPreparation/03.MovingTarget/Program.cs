List<int> targets = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string input = string.Empty;

while ((input = Console.ReadLine()) != "End")
{
    List<string> commands = input.Split(" ").ToList();

    switch (commands[0])
    {
        case "Shoot":
            int index = int.Parse(commands[1]);
            int power = int.Parse(commands[2]);

            if (index >= 0 && index < targets.Count)
            {
                targets[index] -= power;
                if (targets[index] <= 0)
                {
                    targets.RemoveAt(index);
                }
            }
            break;
        case "Add":
            index = int.Parse(commands[1]);
            int value = int.Parse(commands[2]);
            if (index >= 0 && index < targets.Count)
            {
                targets.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }
            break;
        case "Strike":
            index = int.Parse(commands[1]);
            int radius = int.Parse(commands[2]);
            if (index + radius < targets.Count && index - radius >= 0)
            {
                targets.RemoveRange(index - radius, radius * 2 + 1);
            }
            else
            {
                Console.WriteLine("Strike missed!");
            }
            break;
    }
}

Console.WriteLine(string.Join("|", targets));