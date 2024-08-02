
int intervalN = int.Parse(Console.ReadLine());

string biggestKeg = string.Empty;
double biggestVolume = 0;

for (int i = 1; i <= intervalN; i++)
{
    string modelKeg = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());

    double volume = Math.PI * Math.Pow(radius,2) * height;

    if (volume > biggestVolume)
    {
        biggestVolume = volume;
        biggestKeg = modelKeg;
    }
}

Console.WriteLine(biggestKeg);