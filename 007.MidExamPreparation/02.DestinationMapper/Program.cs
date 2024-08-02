

string input = Console.ReadLine();

string destinations = string.Empty;

int travelPoints = 0;

int i = 0;

while (i < input.Length)
{
    if (input[i] == '/' || input[i] == '=')
    {
        char startMarker = input[i];
        int start = i;

        int j = i + 1;
        while (j < input.Length && input[j] != startMarker)
        {
            j++;
        }

        if (j < input.Length && j > start + 1 && input[j] == startMarker)
        {
            string location = input.Substring(start + 1, j - start - 1);

            if (IsValidLocation(location))
            {
                if (destinations.Length != 0)
                {
                    destinations += ", ";
                }

                destinations += location;
                travelPoints += location.Length;
            }
            i = j + 1;
        }
        else
        {
            i++;
        }
    }
    else
    {
        i++;
    }
}

Console.WriteLine($"Destinations: {destinations}");
Console.WriteLine($"Travel Points: {travelPoints}");

bool IsValidLocation(string location)
{
    if (location.Length < 3)
    {
        return false;
    }

    if (!char.IsUpper(location[0]))
    {
        return false;
    }

    for (int i = 1; i < location.Length; i++)
    {
        if (!char.IsLetter(location[i]))
        {
            return false;
        }
    }

    return true;
}