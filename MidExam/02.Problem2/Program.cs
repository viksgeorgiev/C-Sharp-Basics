

List<int> items = Console.ReadLine().Split("|").Select(int.Parse).ToList();

string input = string.Empty;
int totalItemCollected = 0;



while ((input = Console.ReadLine()) != "Adventure over")
{
    string[] command = input.Split(" ").ToArray();

    switch (command[0])
    {
        case "Step":
            List<string> move = command[1].Split("$").ToList();

            string direction = move[0];
            int startIndex = int.Parse(move[1]);
            int steps = int.Parse(move[2]);
            int landedIndex = 0;
            switch (direction)
            {
                case "Backward":
                    if (IsCorrectIndex(startIndex, items))
                    {
                        steps = steps % items.Count;
                        if (startIndex - steps < 0)
                        {
                            int goRound = startIndex - steps;
                            landedIndex = (items.Count) - Math.Abs(goRound);
                        }
                        else
                        {
                            landedIndex = startIndex - steps;
                        }
                        totalItemCollected += items[landedIndex];
                        items[landedIndex] = 0;
                    }
                    break;
                case "Forward":
                    if (IsCorrectIndex(startIndex, items))
                    {
                        steps = steps % items.Count;
                        if (startIndex + steps > items.Count - 1)
                        {
                            int goRound = (startIndex + steps) - (items.Count);
                            landedIndex = goRound;
                        }
                        else
                        {
                            landedIndex = startIndex + steps;
                        }
                        totalItemCollected += items[landedIndex];
                        items[landedIndex] = 0;
                    }
                    break;
            }

            break;
        case "Double":
            int index = int.Parse(command[1]);
            if (IsCorrectIndex(index, items))
            {
                items[index] *= 2;
            }
            break;
        case "Switch":
            items.Reverse();
            break;
    }
}

Console.WriteLine(string.Join(" - ", items));
Console.WriteLine($"Robo finished the adventure with {totalItemCollected} items!");

bool IsCorrectIndex(int startIndex, List<int> items)
{
    return (startIndex >= 0 && startIndex < items.Count);
}