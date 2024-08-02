string[] input = Console.ReadLine().Split().ToArray();

int maxSeq = int.MinValue;
string maxElement = string.Empty;

int currentSequence = 1;

for (int i = 1; i < input.Length; i++)
{
    if (input[i] == input[i - 1])
    {
        currentSequence++;
    }
    else
    {
        currentSequence = 1;
    }

    if (currentSequence > maxSeq)
    {
        maxSeq = currentSequence;
        maxElement = input[i];
    }
}

for (int i = 1; i <= maxSeq; i++)
{
    Console.Write($"{maxElement} ");
}