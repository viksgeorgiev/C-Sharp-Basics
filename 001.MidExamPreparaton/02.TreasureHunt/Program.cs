
List<string> loot = Console.ReadLine().Split("|").ToList();

string input = string.Empty;

while ((input = Console.ReadLine()) != "Yohoho!")
{
    List<string> action = input.Split().ToList();

	switch (action[0])
	{
		case "Loot":
            for (int i = 1; i < action.Count; i++)
            {
                if (!loot.Contains(action[i]))
                {
                    loot.Insert(0, action[i]);
                }
            }
			break;
        case "Drop":
            int index = int.Parse(action[1]);
            if ((index >= 0) && (index <= loot.Count - 1))
            {
                loot.Add(loot[index]);
                loot.RemoveAt(index);
            }
            break;
        case "Steal":
            int count = int.Parse(action[1]);
            List<string> stolen = new List<string>();

            if (count > loot.Count) 
            {
                Console.WriteLine(string.Join(", ",loot));
                loot.Clear();
            }
            else
            {
                for (int i = (loot.Count - count); i < loot.Count; i++) 
                {
                    stolen.Add(loot[i]);
                }
                loot.RemoveRange(loot.Count - count, count);
                Console.WriteLine(string.Join(", ", stolen));
            }
            break;
    }
}

if (loot.Count > 0)
{
    double avgGain = 0;
    double sum = 0;
    foreach (string treasure in loot)
    {
        sum += treasure.Length; 
    }
    avgGain = sum / loot.Count;
    Console.WriteLine($"Average treasure gain: {avgGain:F2} pirate credits.");
}
else
{
    Console.WriteLine("Failed treasure hunt.");
}