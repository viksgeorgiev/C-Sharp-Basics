
string password = Console.ReadLine();
bool isNotValid = false;

CheckLength(password);
CheckLettersDigits(password);
CheckTwoDigits(password);

void CheckLength(string password)
{
    if (password.Length >= 6 && password.Length <= 10)
    {

    }
    else
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
        isNotValid = true;
    }
}

void CheckLettersDigits(string password)
{
    for (int i = 0; i < password.Length; i++) 
    {
        if ((password[i] >= 48 && password[i] <= 57) 
            || (password[i] >= 65 && password[i] <= 90)
            || (password[i] >= 97 && password[i] <= 122) )
        {

        }
        else 
        {
            Console.WriteLine("Password must consist only of letters and digits");
            isNotValid = true;
            break;
        }
    }
}

void CheckTwoDigits(string password)
{
    int counter = 0;

    for (int i = 0; i < password.Length; i++)
    {
        if ((password[i] >= 48 && password[i] <= 57))
        {
            counter++;
        }
    }
    if (counter < 2)
    {
        Console.WriteLine("Password must have at least 2 digits");
        isNotValid = true;
    }
}

if (!isNotValid)
{
    Console.WriteLine("Password is valid");
}