
int N = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());
int targetCount = 0;
int originalN = N;

while (N >= M)
{
    N -= M;
    targetCount++;

    if (N == originalN / 2 && Y != 0)
    {
        if (originalN % 2 == 0)
        {
            N /= Y;
        }
    }
}

Console.WriteLine(N);
Console.WriteLine(targetCount);