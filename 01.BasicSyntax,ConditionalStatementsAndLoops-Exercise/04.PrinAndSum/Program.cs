int startOfSequence = int.Parse(Console.ReadLine());
int endOfSequence  = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = startOfSequence; i <= endOfSequence; i++)
{
    Console.Write($"{i} ");
    sum += i;
}
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");