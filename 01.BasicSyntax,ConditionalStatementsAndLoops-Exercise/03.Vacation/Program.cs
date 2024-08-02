
double countOfPeople = double.Parse(Console.ReadLine());
string groupType = Console.ReadLine();
string dayOfWeek = Console.ReadLine();

double price = 0;

switch (groupType)
{
    case "Students":
        switch (dayOfWeek)
        {
            case "Friday":
                price = countOfPeople * 8.45;
                break;
            case "Saturday":
                price = countOfPeople * 9.80;
                break;
            case "Sunday":
                price = countOfPeople * 10.46;
                break;
        }
        if (countOfPeople >= 30)
        {
            price -= price * 0.15;
        }
        break;
    case "Business":
        if (countOfPeople >= 100)
        {
            countOfPeople -= 10;
        }
        switch (dayOfWeek)
        {
            case "Friday":
                price = countOfPeople * 10.90;
                break;
            case "Saturday":
                price = countOfPeople * 15.60;
                break;
            case "Sunday":
                price = countOfPeople * 16;
                break;
        }
        break;
    case "Regular":
        switch (dayOfWeek)
        {
            case "Friday":
                price = countOfPeople * 15;
                break;
            case "Saturday":
                price = countOfPeople * 20;
                break;
            case "Sunday":
                price = countOfPeople * 22.50;
                break;

        }
        if (countOfPeople >= 10 && countOfPeople <= 20)
        {
            price -= price * 0.05;
        }
        break;
}

Console.WriteLine($"Total price: {price:F2}");