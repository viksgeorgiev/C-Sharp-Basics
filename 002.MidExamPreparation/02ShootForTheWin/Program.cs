

List<int> target = Console.ReadLine().Split().Select(int.Parse).ToList();

string input = string.Empty;

while ((input = Console.ReadLine()) != "End")
{
    int index = int.Parse(input);
    if (index >= 0 && index < target.Count)
    {
        if (target[index] != -1)
        {
            int shotValue = target[index];
            target[index] = -1;
            for (int i = 0; i < target.Count; i++)
            {
                if (shotValue < target[i] && target[i] != -1)
                {
                    target[i] -= shotValue;
                }
                else if (shotValue >= target[i] && target[i] != -1)
                {
                    target[i] += shotValue;
                }
            }
        }
    }
}

int shotTargets = 0;

foreach (int shotAt in target)
{
    if (shotAt == -1)
    {
        shotTargets++;
    }
}

Console.WriteLine($"Shot targets: {shotTargets} -> {string.Join(" ", target)}");