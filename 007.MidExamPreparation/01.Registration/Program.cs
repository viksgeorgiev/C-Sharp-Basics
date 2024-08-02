using System.Reflection.Metadata.Ecma335;

string username = Console.ReadLine();

List<string> characters = username.Select(c => c.ToString()).ToList();

string input = string.Empty;

while ((input = Console.ReadLine()) != "Registration")
{
    List<string> commands = input.Split(" ").ToList();

    switch (commands[0])
    {
        case "Letters":
            switch (commands[1])
            {
                case "Lower":
                    for (int i = 0; i < characters.Count; i++)
                    {
                        characters[i] = characters[i].ToLower();
                    }
                    Console.WriteLine(string.Join("", characters));
                    break;
                case "Upper":
                    for (int i = 0; i < characters.Count; i++)
                    {
                        characters[i] = characters[i].ToUpper();
                    }
                    Console.WriteLine(string.Join("", characters));
                    break;
            }
            break;
        case "Reverse":
            if (isValidIndex(commands[1], characters) && isValidIndex(commands[2], characters))
            {
                List<string> reversed = new List<string>();
                for (int i = int.Parse(commands[1]); i <= int.Parse(commands[2]); i++)
                {
                    reversed.Add(characters[i]);
                }
                reversed.Reverse();
                Console.WriteLine(string.Join("", reversed));
            }
            break;
        case "Substring":
            string charactersString = string.Join("", characters);
            if (charactersString.Contains(commands[1]))
            {
                foreach (char letter in commands[1])
                {
                    characters.Remove(letter.ToString());
                }
                Console.WriteLine(string.Join("", characters));
            }
            else
            {
                Console.WriteLine($"The username {string.Join("", characters)} doesn't contain {commands[1]}.");
            }
            break;
        case "Replace":
            string ToBeDash = commands[1];
            while (characters.Contains(commands[1]))
            {
                int indexToChange = characters.IndexOf(commands[1]);
                characters[indexToChange] = "-";
            }
            Console.WriteLine(string.Join("", characters));
            break;
        case "IsValid":
            if (characters.Contains(commands[1]))
            {
                Console.WriteLine("Valid username.");
            }
            else
            {
                Console.WriteLine($"{commands[1]} must be contained in your username.");
            }
            break;
    }
}

bool isValidIndex(string index, List<string> characters)
{
    return (int.Parse(index) >= 0 && int.Parse(index) < characters.Count);
}