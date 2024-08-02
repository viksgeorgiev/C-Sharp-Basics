
int lostGamesCount = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

int headsetBroken = 0;
int mouseBroken = 0;
int keyboardBroken = 0;
int displayBroken = 0;

for (int i = 1; i <= lostGamesCount; i++)
{
    if (i % 2 == 0)
    {
        headsetBroken++;
    }
    if (i % 3 == 0)
    {
        mouseBroken++;
    }
    if (i % 2 == 0 && i % 3 == 0)
    {
        keyboardBroken++;
    }
    if (i % 2 == 0 && i % 3 == 0 && keyboardBroken % 2 == 0)
    {
        displayBroken++;
    }
}

double rageExpenses = (mouseBroken * mousePrice) +
    (keyboardBroken * keyboardPrice) +
    (headsetBroken * headsetPrice) +
    (displayBroken * displayPrice);

Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");