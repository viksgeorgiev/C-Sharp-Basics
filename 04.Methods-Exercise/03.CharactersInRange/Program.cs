

char char1 = char.Parse(Console.ReadLine());
char char2 = char.Parse(Console.ReadLine());
char temporary = ' ';

if (char1 <= char2)
{

}
else
{
    temporary = char1;
    char1 = char2;
    char2 = temporary; 
}
 
PrintCharsSequence(char1, char2);

void PrintCharsSequence(char char1, char char2)
{
    for (int i = char1 + 1; i < char2; i++)
    {
        Console.Write($"{(char)i} ");
    }
}
