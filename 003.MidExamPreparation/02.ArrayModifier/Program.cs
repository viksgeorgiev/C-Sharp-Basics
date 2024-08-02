
List<int> elements = Console.ReadLine().Split().Select(int.Parse).ToList();

string input = string.Empty;

while ((input = Console.ReadLine()) != "end")
{
    string[] commands = input.Split().ToArray();

    switch (commands[0])
    {
        case "swap":
            int index1 = int.Parse(commands[1]);
            int index2 = int.Parse(commands[2]);
            int temp = 0;

            temp = elements[index1];
            elements[index1] = elements[index2];
            elements[index2] = temp;
            break;
        case "multiply":
            index1 = int.Parse(commands[1]);
            index2 = int.Parse(commands[2]);
            int multiplied = elements[index1] * elements[index2];
            elements[index1] = multiplied;

            break;
        case "decrease":

            for (int i = 0; i < elements.Count;i++)
            {
                elements[i]--;
            }
                break;
    }
}

Console.WriteLine(string.Join(", ", elements));