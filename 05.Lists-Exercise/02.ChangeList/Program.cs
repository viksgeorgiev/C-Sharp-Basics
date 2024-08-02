
List<int> manipulatorList = Console.ReadLine().Split().Select(int.Parse).ToList();

string input = string.Empty;

while ((input = Console.ReadLine()) != "end")
{
    List<string> command = input.Split().ToList();

    if (command[0] == "Delete")
    {
        int element = int.Parse(command[1]);

        for (int i = 0; i < manipulatorList.Count; i++)
        {
            if (manipulatorList[i] == element)
            {
                manipulatorList.RemoveAt(i);
            }
        }
    }
    else
    {
        int element = int.Parse(command[1]);
        int position = int.Parse(command[2]);

        manipulatorList.Insert(position, element);
    }
}

Console.WriteLine(string.Join(" ",manipulatorList));



