
double balance = double.Parse(Console.ReadLine());

string input = string.Empty;
bool isNoMoney = false;
double totalSpent = 0;

while ((input = Console.ReadLine()) != "Game Time")
{
    double gamePrice = 0;
    string gameBought = string.Empty;
	switch (input)
	{
        case "OutFall 4":
            gamePrice = 39.99;
            gameBought = "OutFall 4";
            break;
        case "CS: OG":
            gamePrice = 15.99;
            gameBought = "CS: OG";
            break;
        case "Zplinter Zell":
            gamePrice = 19.99;
            gameBought = "Zplinter Zell";
            break;
        case "Honored 2":
            gamePrice = 59.99;
            gameBought = "Honored 2";
            break;
        case "RoverWatch":
            gamePrice = 29.99;
            gameBought = "RoverWatch";
            break;
        case "RoverWatch Origins Edition":
            gamePrice = 39.99;
            gameBought = "RoverWatch Origins Edition";
            break;
        default:
            Console.WriteLine("Not Found");
            continue;
	}

    if (gamePrice > balance)
    {
        Console.WriteLine("Too Expensive");
        continue;
    }
    if (gamePrice <= balance)
    {
        balance -= gamePrice;
        totalSpent += gamePrice;
        Console.WriteLine($"Bought {gameBought}");
    }

    if (balance <= 0)
    {
        Console.WriteLine("Out of money!");
        isNoMoney = true;
        break;
    }
}




if (!isNoMoney)
{
    
    Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${(balance):F2}");
}