int key = int.Parse(Console.ReadLine());
int lines = int.Parse(Console.ReadLine());

string message = String.Empty;

for (int i = 0; i < lines; i++)
{
    char code = char.Parse(Console.ReadLine());
    message += (char)(code + key);
}

Console.WriteLine(message);