
int countOfOrdersN = int.Parse(Console.ReadLine());

double total = 0;

for (int i = 1; i <= countOfOrdersN; i++)
{
    double pricePerCapsule = double.Parse(Console.ReadLine());
    int days = int.Parse((Console.ReadLine()));
    int capsulesCount = int.Parse((Console.ReadLine()));

    double price = ((days * capsulesCount) * pricePerCapsule);
    total += price;

    Console.WriteLine($"The price for the coffee is: ${price:F2}");
}

Console.WriteLine($"Total: ${total:F2}");
