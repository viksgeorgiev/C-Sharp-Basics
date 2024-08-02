int input = int.Parse(Console.ReadLine());

string result = string.Empty;


for (int i = 1; i <= input; i++)
{
    int typedIn = int.Parse(Console.ReadLine());
    int digitsNumber = typedIn.ToString().Length;
    int mainDigit = typedIn.ToString()[0] - '0';
    if (mainDigit != 0)
    {
        int offset = (mainDigit - 2) * 3;
        if (mainDigit == 8 || mainDigit == 9)
        {
            offset++;
        }

        int letterIndex = (offset + ((typedIn.ToString().Length) - 1));

        result += (char)('a' + letterIndex);
    }
    else if (mainDigit == 0)
    {
        result += (char)(32);
    }
}

Console.WriteLine(result);