

List<int> houses = Console.ReadLine().Split("@").Select(int.Parse).ToList();

string input = string.Empty;
int jumpingIndex = 0;

while ((input = Console.ReadLine()) != "Love!")
{
    string[] jumps = input.Split(" ").ToArray();

    int length = int.Parse(jumps[1]);
    
    jumpingIndex += length;
    if (jumpingIndex > houses.Count - 1)
    {
        jumpingIndex = 0;
    }

    if (houses[jumpingIndex] <= 0)
    {
        Console.WriteLine($"Place {jumpingIndex} already had Valentine's day.");
    }
    else 
    {
        houses[jumpingIndex] -= 2;
        if (houses[jumpingIndex] <= 0)
        {
            Console.WriteLine($"Place {jumpingIndex} has Valentine's day.");
        }
    }
}

Console.WriteLine($"Cupid's last position was {jumpingIndex}.");
bool isAllZero = true;
int notZeroCounter = 0;
foreach (int value in houses)
{
    if (value != 0)
    {
        isAllZero = false;
        notZeroCounter++;
    }
}

if (isAllZero)
{
    Console.WriteLine("Mission was successful.");
}
else
{
    Console.WriteLine($"Cupid has failed {notZeroCounter} places.");
}