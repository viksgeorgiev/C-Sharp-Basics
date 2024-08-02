
string input = Console.ReadLine();

PrintMiddleLetters(input);

void PrintMiddleLetters(string input)
{
    int length = input.Length;

    if (length % 2 == 0)
    {
         Console.WriteLine($"{input[(length / 2) - 1]}{input[(length / 2)]}");
    }
    else
    {
        Console.WriteLine($"{input[length / 2]}");
    }
}