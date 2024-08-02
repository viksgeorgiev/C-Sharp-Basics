int guestsNumber = int.Parse(Console.ReadLine());

List<string> guestList = new List<string>();


for (int i = 0; i < guestsNumber; i++)
{
    List<string> input = Console.ReadLine().Split().ToList();
    string name = input[0];

    if (input.Count == 3)
    {
        if (guestList.Contains(name))
        {
            Console.WriteLine($"{name} is already in the list!");
        }
        else
        {
            guestList.Add(name);
        }
    }
    else
    {
        if (guestList.Contains(name)) 
        {
            guestList.Remove(name);
        }
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }
    }
    
}

foreach(string guest in guestList)
{
    Console.WriteLine(guest);
}






