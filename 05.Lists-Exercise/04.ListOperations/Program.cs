

List<int> numberList = Console.ReadLine().Split().Select(int.Parse).ToList();

string input = string.Empty;

while ((input = Console.ReadLine()) != "End")
{
    List<string> command = input.Split().ToList();

    switch (command[0])
    {
        case "Add":
            
                AddToArray(ParseInput(command[1]));
       
            break;
        case "Insert":
            if (IsValidIndex(ParseInput(command[2])))
            {
                InsertNumberToList(ParseInput(command[1]), ParseInput(command[2]));
            }
            else
            {
                NotvalidIndex();
            }
            break;
        case "Remove":
            if (IsValidIndex(ParseInput(command[1])))
            {
                RemoveFromIndex(ParseInput(command[1]));
            }
            else
            {
                NotvalidIndex();
            }
            break;
        case "Shift":
            if (command[1] == "left")
            {
                ShiftLeft(ParseInput(command[2]));
            }
            else if (command[1] == "right")
            {
                ShiftRight(ParseInput(command[2]));
            }
            break;
    }
}

Console.WriteLine(string.Join(" ", numberList));

void ShiftLeft(int counter)
{
    counter %= numberList.Count;

    for (int i = 0; i < counter; i++)
    {
        numberList.Add(numberList[0]);
        numberList.RemoveAt(0);
    }

}

void ShiftRight(int counter)
{
    counter %= numberList.Count;

    for (int i = 0; i < counter; i++)
    {
        numberList.Insert(0, (numberList[numberList.Count - 1]));
        numberList.RemoveAt(numberList.Count - 1);
    }

}

void InsertNumberToList(int number, int index)
{
    numberList.Insert(index, number);
}

bool IsValidIndex(int index)
{
    if (index >= 0 && index <= numberList.Count)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void AddToArray(int number)
{
    numberList.Add(number);
}

static int ParseInput(string number)
{
    return int.Parse(number);
}

void NotvalidIndex()
{
    Console.WriteLine("Invalid index");
}

void RemoveFromIndex(int index)
{
    numberList.RemoveAt(index);
}