
int numberOfLinesN = int.Parse(Console.ReadLine());

int loadOfTank = 0;


for (int i = 1; i <= numberOfLinesN; i++)
{
    int litersInput = int.Parse(Console.ReadLine());
    if (litersInput + loadOfTank <= 255)
    {
        loadOfTank += litersInput;
    }
    else
    {
        Console.WriteLine("Insufficient capacity!");
    }
}

Console.WriteLine(loadOfTank);