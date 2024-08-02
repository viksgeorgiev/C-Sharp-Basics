int daysOfPlunder = int.Parse(Console.ReadLine());
int dailyPlunder  = int.Parse(Console.ReadLine());
double expectedPlunder  = double.Parse(Console.ReadLine());

double gainedPlunder = 0;


for (int i = 1; i <= daysOfPlunder; i++)
{
    gainedPlunder += dailyPlunder;

    if (i % 3 == 0)
    {
        double additionalPlunder = dailyPlunder * 0.5;
        gainedPlunder += additionalPlunder;
    }

    if (i % 5 == 0)
    {
        gainedPlunder -= gainedPlunder * 0.3;
    }
}

if (gainedPlunder >= expectedPlunder)
{
    Console.WriteLine($"Ahoy! {gainedPlunder:F2} plunder gained.");
}
else
{
    double collectedPlunder = (gainedPlunder / expectedPlunder) * 100;

    Console.WriteLine($"Collected only {collectedPlunder:F2}% of the plunder.");
}