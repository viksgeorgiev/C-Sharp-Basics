
using System.Threading;

List<string> rooms = Console.ReadLine().Split("|").ToList();

int health = 100;
int bitcoin = 0;
int bestRoom = 0;
int healedFor = 0;
bool isDead = false;

for (int i = 0; i < rooms.Count; i++)
{
    string[] action = rooms[i].Split(" ").ToArray();

    int value = int.Parse(action[1]);

    switch (action[0])
    {
        case "potion":
            if (value + health > 100)
            {
                healedFor = 100 - health;
                health = 100;
            }
            else
            {
                health += value;
                healedFor = value;
            }
            Console.WriteLine($"You healed for {healedFor} hp.");
            Console.WriteLine($"Current health: {health} hp.");
            break;
        case "chest":
            bitcoin += value;
            Console.WriteLine($"You found {value} bitcoins.");
            break;
        default:
            health -= value;
            if (health <= 0)
            {
                Console.WriteLine($"You died! Killed by {action[0]}.");
                Console.WriteLine($"Best room: {i + 1}");
                isDead = true;
                break;
            }
            else
            {
                Console.WriteLine($"You slayed {action[0]}.");
            }
            break;
    }
    if (isDead) { break; }
}

if (!isDead)
{
    Console.WriteLine($"You've made it!");
    Console.WriteLine($"Bitcoins: {bitcoin}");
    Console.WriteLine($"Health: {health}");
}