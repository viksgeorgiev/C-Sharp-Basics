

List<string> consoleInput = Console.ReadLine().Split("|").ToList();

List<int> numbers = new List<int>();


for (int i = consoleInput.Count - 1; i >= 0; i--)
{
    List<int> segmentNumbers = consoleInput[i]
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

    numbers.AddRange(segmentNumbers);
}

Console.WriteLine(string.Join(" ", numbers));

