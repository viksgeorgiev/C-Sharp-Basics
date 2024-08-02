

List<string> journal = Console.ReadLine().Split(", ").ToList();

string input = string.Empty;


while ((input = Console.ReadLine()) != "Craft!")
{
    List<string> commands = input.Split(" - ").ToList();

    string command = commands[0];
    string item = commands[1];
    switch (command)
    {
        case "Collect":
            if (!IsContainedInJournal(item, journal))
            {
                journal.Add(item);
            }
            break;
        case "Drop":
            if (IsContainedInJournal(item, journal))
            {
                journal.Remove(item);
            }
            break;
        case "Combine Items":
            string[] items = commands[1].Split(":").ToArray();
            if (IsContainedInJournal(items[0], journal))
            {    
                int indexToInsert = journal.IndexOf(items[0]) + 1;
                journal.Insert(indexToInsert, items[1]);
            }
            break;
        case "Renew":
            if (IsContainedInJournal(item, journal))
            {
                journal.Add(item);
                journal.Remove(item);
            }
            break;
    }
}


Console.WriteLine(string.Join(", ", journal));

bool IsContainedInJournal(string item, List<string> journal)
{
    return journal.Contains(item);
}