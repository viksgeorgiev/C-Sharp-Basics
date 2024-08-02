string input = Console.ReadLine();

double price;
double allPrices = 0;
double allTaxes = 0;
double totalPrice = 0;

while (input != "special" && input != "regular")
{
    price = double.Parse(input);

    if (price < 0)
    {
        Console.WriteLine("Invalid price!");
        input = Console.ReadLine();
        continue;
    }
    else
    {
        allPrices += price;
        allTaxes += price * 0.20;
    }



    input = Console.ReadLine();
}

totalPrice = allPrices + allTaxes;

if (input == "special")
{
    totalPrice -= totalPrice * 0.10;
}

if (totalPrice == 0)
{
    Console.WriteLine("Invalid order!");
}
else
{
    Console.WriteLine("Congratulations you've just bought a new computer!");
    Console.WriteLine($"Price without taxes: {allPrices:F2}$");
    Console.WriteLine($"Taxes: {allTaxes:F2}$");
    Console.WriteLine("-----------");
    Console.WriteLine($"Total price: {totalPrice:F2}$");
}



