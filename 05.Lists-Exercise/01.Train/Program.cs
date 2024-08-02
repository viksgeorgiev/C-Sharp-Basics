

List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();

int maxCapacity = int.Parse(Console.ReadLine());

string input = string.Empty;

while ((input = Console.ReadLine()) != "end")
{
    List<string> passengers = input.Split().ToList();

    if (passengers.Count == 2)
    {
        train.Add(int.Parse(passengers[1]));
    }
    else
    {
        for (int i = 0; i < train.Count; i++)
        {
            int passengersCount = int.Parse(passengers[0]);

            if (passengersCount + train[i] <= maxCapacity)
            {
                train[i] = passengersCount + train[i];
                break;
            }
        }
    }
}

foreach (int cart in train)
{
    Console.Write($"{cart} ");
}