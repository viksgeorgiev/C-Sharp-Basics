List<int> sequence = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

double avgNumber = (double)sequence.Sum() / sequence.Count;

List<int> greaterThanAvg = new List<int>();

foreach (int number in sequence)
{
    if (number > avgNumber)
    {
        greaterThanAvg.Add(number);
    }
}

greaterThanAvg.Sort();
greaterThanAvg.Reverse();



if (greaterThanAvg.Count == 0)
{
    Console.WriteLine("No");
}
else
{
    if (greaterThanAvg.Count > 5)
    {
        for (int number = 0; number <= 4; number++)
        {
            Console.Write($"{greaterThanAvg[number]} ");
        }
    }
    else 
    {
        foreach (int number in greaterThanAvg)
        {
            Console.Write($"{number} ");
        }
    }
}

