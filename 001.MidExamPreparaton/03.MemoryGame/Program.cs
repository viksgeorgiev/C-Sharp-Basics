
using System.Xml.Linq;

List<string> elements = Console.ReadLine().Split(" ").ToList();

string input = string.Empty;

int movesCounter = 0;
bool isWon = false;

while ((input = Console.ReadLine()) != "end")
{

    List<int> indexes = input.Split(" ").Select(int.Parse).ToList();
    int index1 = indexes[0];
    int index2 = indexes[1];

    if (elements.Count == 0)
    {
        Console.WriteLine($"You have won in {movesCounter} turns!");
        isWon = true;
        break;
    }

    movesCounter++;

    if ((index1 == index2) || ((index1 < 0 || index1 >= elements.Count) || (index2 < 0 || index2 >= elements.Count)))
    {
        int indexToAdd = elements.Count / 2;
        for (int i = 1; i <= 2; i++)
        {
            elements.Insert(indexToAdd, ($"-{movesCounter}a"));
        }
        Console.WriteLine("Invalid input! Adding additional elements to the board");
        continue;
    }
    else
    {
        if (elements[index1] == elements[index2])
        {
            Console.WriteLine($"Congrats! You have found matching elements - {elements[index1]}!");
            if (index1 > index2)
            {
                elements.RemoveAt(index1);
                elements.RemoveAt(index2);
            }
            else if (index1 < index2)
            {
                elements.RemoveAt(index2);
                elements.RemoveAt(index1);
            }
        }
        else if (elements[index1] != elements[index2])
        {
            Console.WriteLine("Try again!");
        }

        if (elements.Count == 0)
        {
            Console.WriteLine($"You have won in {movesCounter} turns!");
            isWon = true;
            break;
        }
    }
}

if (!isWon)
{
    Console.WriteLine("Sorry you lose :(");
    Console.WriteLine(string.Join(" ", elements));
}
