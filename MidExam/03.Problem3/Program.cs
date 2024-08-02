

List<int> items = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

int entryIndex = int.Parse(Console.ReadLine());

string type = Console.ReadLine();

int leftSideDamage = 0;
int rightSideDamage = 0;


if (type == "cheap")
{
    for (int i = 0; i < entryIndex; i++)
    {
        if (items[i] < items[entryIndex])
        {
            leftSideDamage += items[i];
        }
    }

    for (int i = entryIndex + 1; i < items.Count; i++)
    {
        if (items[i] < items[entryIndex])
        {
            rightSideDamage += items[i];
        }
    }
}
else if (type == "expensive")
{

    for (int i = 0; i < entryIndex; i++)
    {
        if (items[i] >= items[entryIndex])
        {
            leftSideDamage += items[i];
        }
    }

    for (int i = entryIndex + 1; i < items.Count; i++)
    {
        if (items[i] >= items[entryIndex])
        {
            rightSideDamage += items[i];
        }
    }
}

if (rightSideDamage > leftSideDamage)
{
    Console.WriteLine($"Right - {rightSideDamage}");
}
else
{
    Console.WriteLine($"Left - {leftSideDamage}");
}