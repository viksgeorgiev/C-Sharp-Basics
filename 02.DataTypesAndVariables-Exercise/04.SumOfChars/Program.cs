int numberOfLinesN = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= numberOfLinesN; i++)
{
    char line = char.Parse(Console.ReadLine());
    sum += (int)line;
}

Console.WriteLine($"The sum equals: {sum}");