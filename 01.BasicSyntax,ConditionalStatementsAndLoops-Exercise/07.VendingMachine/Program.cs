
string input = string.Empty;

double acummulatedCoins = 0;

while ((input = Console.ReadLine()) != "Start")
{
    switch (input)
    {
        case "0.1":
            acummulatedCoins += 0.1;
            break;
        case "0.2":
            acummulatedCoins += 0.2;
            break;
        case "0.5":
            acummulatedCoins += 0.5;
            break;
        case "1":
            acummulatedCoins += 1;
            break;
        case "2":
            acummulatedCoins += 2;
            break;
        default:
            Console.WriteLine($"Cannot accept {input}");
            break;
    }
}

while ((input = Console.ReadLine()) != "End")
{
    if (input == "Nuts")
    {
        if (acummulatedCoins >= 2.0)
        {
            acummulatedCoins -= 2.0;
            Console.WriteLine("Purchased nuts");
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (input == "Water")
    {
        if (acummulatedCoins >= 0.7)
        {
            acummulatedCoins -= 0.7;
            Console.WriteLine("Purchased water");
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (input == "Crisps")
    {
        if (acummulatedCoins >= 1.5)
        {
            acummulatedCoins -= 1.5;
            Console.WriteLine("Purchased crisps");
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (input == "Soda")
    {
        if (acummulatedCoins >= 0.8)
        {
            acummulatedCoins -= 0.8;
            Console.WriteLine("Purchased soda");
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (input == "Coke")
    {
        if (acummulatedCoins >= 1.0)
        {
            acummulatedCoins -= 1.0;
            Console.WriteLine("Purchased coke");
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else
    {
        Console.WriteLine("Invalid product");
    }
}
Console.WriteLine($"Change: {acummulatedCoins:F2}");





