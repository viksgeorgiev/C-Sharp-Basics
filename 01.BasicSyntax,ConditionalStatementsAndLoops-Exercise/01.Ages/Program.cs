/*
 * Write a program that determines if a person is baby, child, teenager, adult or elder based on the given age. The boundaries are:
•	0-2 – baby
•	3-13 – child
•	14-19 – teenager
•	20-65 – adult
•	>= 66 – elder
All the values are inclusive.
*/

int age = int.Parse(Console.ReadLine());

string ageBracket = string.Empty;

if (age >= 0 && age <= 2)
{
    ageBracket = "baby";
}
else if (age >= 3 && age <= 13)
{
    ageBracket = "child";
}
else if (age >= 14 && age <= 19)
{
    ageBracket = "teenager";
}
else if (age >= 20 && age <= 65)
{
    ageBracket = "adult";
}
else
{
    ageBracket = "elder";
}

Console.WriteLine(ageBracket);