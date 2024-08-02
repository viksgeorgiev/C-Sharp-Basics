
List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();

int maxHealth = int.Parse(Console.ReadLine());

string input = string.Empty;
bool isStalemate = true;


while ((input = Console.ReadLine()) != "Retire")
{
    List<string> commands = input.Split().ToList();

	switch (commands[0])
	{
		case "Fire":
            int indexToHit = int.Parse(commands[1]);
            int damage = int.Parse(commands[2]);
            if (IsValidIndex(indexToHit, warShip))
            {
                if (damage >= warShip[indexToHit])
                {
                    Console.WriteLine("You won! The enemy ship has sunken.");
                    isStalemate = false;
                    return;
                }
                else
                {
                    warShip[indexToHit] -= damage;
                }
            }
			break;
        case "Defend":
            int startIndex = int.Parse(commands[1]);
            int endIndex = int.Parse(commands[2]);
            int damageShip = int.Parse(commands[3]);
            if (IsValidIndex(startIndex, pirateShip) && IsValidIndex(endIndex, pirateShip))
            {
                for (int i = startIndex; i <= endIndex;i++)
                {
                    if (damageShip >= pirateShip[i])
                    {
                        Console.WriteLine("You lost! The pirate ship has sunken.");
                        isStalemate = false;
                        return;
                    }
                    else
                    {
                        pirateShip[i] -= damageShip;
                    }
                }
            }
            break;
        case "Repair":
            int repairIndex = int.Parse(commands[1]);
            int healthForRepair = int.Parse(commands[2]);

            if(IsValidIndex(repairIndex, pirateShip))
            {
                if (pirateShip[repairIndex] + healthForRepair > maxHealth )
                {
                    pirateShip[repairIndex] = maxHealth;
                }
                else
                {
                    pirateShip[repairIndex] += healthForRepair; 
                }
            }
            break;
        case "Status":
            int counter = 0;
            for (int i = 0; i < pirateShip.Count; i++)
            {
                if (pirateShip[i] < (maxHealth * 0.20))
                {
                    counter++;
                }
            }
            Console.WriteLine($"{counter} sections need repair.");
            break;
    }
}

if (isStalemate)
{
    Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
    Console.WriteLine($"Warship status: {warShip.Sum()}");
}

bool IsValidIndex(int index, List<int> warShip)
{
    
    return (index >= 0 && index < warShip.Count);
}