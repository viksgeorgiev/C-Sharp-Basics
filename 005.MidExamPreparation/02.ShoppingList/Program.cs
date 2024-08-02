

List<string> shoppingList = Console.ReadLine().Split("!").ToList();

string input = string.Empty;

while((input = Console.ReadLine()) != "Go Shopping!")
{
    string[] commands = input.Split(" ").ToArray();

    switch (commands[0])
    {
        case "Urgent":
            string item = commands[1];
            if (!IsPresentInLIst(item, shoppingList))
            {
                shoppingList.Insert(0, item);
            }
            break;
        case "Unnecessary":
            item = commands[1];
            if (IsPresentInLIst(item, shoppingList))
            {
                shoppingList.Remove(item);
            }
            break;
        case "Correct":
            item = commands[1];
            string newItem = commands[2];
            if (IsPresentInLIst(item, shoppingList))
            {
                shoppingList[shoppingList.IndexOf(item)] = newItem; 
                
            }
            break;
        case "Rearrange":
            item = commands[1];
            if (IsPresentInLIst(item, shoppingList))
            {
                shoppingList.Add(item);
                shoppingList.Remove(item);
            }
            break;
    }

}

Console.WriteLine(string.Join(", ", shoppingList));

bool IsPresentInLIst(string item, List<string> shopingList)
{
    return shopingList.Contains(item);
}