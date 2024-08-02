int yield = int.Parse(Console.ReadLine());

int daysCounter = 0;
int storage = 0;

while (yield >= 100)
{
    daysCounter++;
    storage += yield;
    storage -= 26;
    yield -= 10; 

}

if (storage < 26)
{
    storage = 0;
}
else
{
    storage -= 26;
}

Console.WriteLine(daysCounter);
Console.WriteLine(storage);