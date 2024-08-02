

List<string> foods = new List<string>();
List<int> quantity = new List<int>();

string input = string.Empty;
int soldGoods = 0;

while ((input = Console.ReadLine()) != "Complete")
{
    List<string> commands = input.Split(" ").ToList();

    int amount = int.Parse(commands[1]);
    string foodType = commands[2];

    switch (commands[0])
    {
        case "Receive":
            if (amount > 0)
            {
                if (foods.Contains(foodType))
                {
                    int indexOfFood = foods.IndexOf(foodType);
                    quantity[indexOfFood] += amount;
                }
                else if (!foods.Contains(foodType))
                {
                    foods.Add(foodType);
                    quantity.Add(amount);
                }
            }
            break;
        case "Sell":
            int indexOfSoldFood = 0;
            if (foods.Contains(foodType))
            {
                indexOfSoldFood = foods.IndexOf(foodType);
            }

            if (!foods.Contains(foodType))
            {
                Console.WriteLine($"You do not have any {foodType}.");
            }
            else if (amount > quantity[indexOfSoldFood])
            {
                Console.WriteLine($"There aren't enough {foodType}. You sold the last {quantity[indexOfSoldFood]} of them.");
                soldGoods += quantity[indexOfSoldFood];
                foods.RemoveAt(indexOfSoldFood);
                quantity.RemoveAt(indexOfSoldFood);
            }
            else
            {
                Console.WriteLine($"You sold {amount} {foodType}.");
                quantity[indexOfSoldFood] -= amount;
                soldGoods += amount;
                if (quantity[indexOfSoldFood] == 0)
                {
                    foods.RemoveAt(indexOfSoldFood);
                    quantity.RemoveAt(indexOfSoldFood);
                }
            }
            break;
    }
}

for (int i = 0; i < foods.Count; i++)
{
    Console.WriteLine($"{foods[i]}: {quantity[i]}");
}

Console.WriteLine($"All sold: {soldGoods} goods");