int lines = int.Parse(Console.ReadLine());

int openParantecies = 0;
int openBracket = 0;
int closeBracket = 0;
bool isUnbalanced = false;

for (int i = 0; i < lines; i++)
{
    string input = Console.ReadLine();
    if (input == "(")
    {
        openParantecies++;
        openBracket++;
        if(openParantecies > 1)
        {
            Console.WriteLine("UNBALANCED");
            isUnbalanced = true; 
            break;
        }
    }
    else if (input == ")") 
    {
        closeBracket++;

        if (openParantecies == 0)
        {
            Console.WriteLine("UNBALANCED");
            isUnbalanced = true;
            break;
        }

        openParantecies = 0;
    }
}

if (!isUnbalanced)
{
    if (openBracket == closeBracket)
    {
        Console.WriteLine("BALANCED");
    }
    else
    {
        Console.WriteLine("UNBALANCED");
    }
}
