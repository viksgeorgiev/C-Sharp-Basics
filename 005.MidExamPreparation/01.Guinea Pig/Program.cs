double foodInGrams = double.Parse(Console.ReadLine()) * 1000;
double hayInGrams = double.Parse(Console.ReadLine()) * 1000;
double coverInGrams = double.Parse(Console.ReadLine()) * 1000;
double pigWeightInGrams = double.Parse(Console.ReadLine()) * 1000;

bool notEnough = false;

for (int i = 1; i <= 30; i++)
{
    foodInGrams -= 300;
    if (i % 2 == 0)
    {
        hayInGrams -= 0.05 * foodInGrams;
    }
    if (i % 3 == 0)
    {
        coverInGrams -= pigWeightInGrams / 3;
    }
    if (foodInGrams <= 0 || hayInGrams <= 0 || coverInGrams <= 0)
    {
        Console.WriteLine("Merry must go to the pet store!");
        notEnough = true;
        break;
    }
}

if (notEnough)
{

}
else
{
    Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodInGrams / 1000:F2}, Hay: {hayInGrams / 1000:F2}, Cover: {coverInGrams / 1000:F2}.");
}