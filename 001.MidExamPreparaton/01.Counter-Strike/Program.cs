int energy = int.Parse(Console.ReadLine());

string input = string.Empty;
int battlesWon = 0;
bool isLost = false;

while ((input = Console.ReadLine()) != "End of battle")
{
    int battleEnergy = int.Parse(input);


    if (battleEnergy > energy)
    {
        Console.WriteLine($"Not enough energy! Game ends with {battlesWon} won battles and {energy} energy");
        isLost = true;
        break;
    }
    
    energy -= battleEnergy; 
    
    battlesWon++;

    if (battlesWon % 3 == 0)
    {
        energy += battlesWon;
    }
}

if (!isLost)
{
    Console.WriteLine($"Won battles: {battlesWon}. Energy left: {energy}");
}