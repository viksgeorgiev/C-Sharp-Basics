
string username = Console.ReadLine();

char[] stringArray = username.ToCharArray();
Array.Reverse(stringArray);
string password = new string(stringArray);

int counterTries = 4;
while (true)
{
    string input = Console.ReadLine();
    if (input != password)
    {
        counterTries--;
        if (counterTries == 0)
        {
            Console.WriteLine($"User {username} blocked!");
            break;
        }
        else if (counterTries > 0)
        {
            Console.WriteLine("Incorrect password. Try again.");
        }
        
    }
    else if (input == password)
    {
        Console.WriteLine($"User {username} logged in.");
        break;
    }
}






