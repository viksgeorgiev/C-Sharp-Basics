int numberInputed = int.Parse(Console.ReadLine());


if (numberInputed % 10 == 0)
{
    Console.WriteLine("The number is divisible by 10");
}
else if (numberInputed % 7 == 0)
{
    Console.WriteLine("The number is divisible by 7");
}
else if (numberInputed % 6 == 0)
{
    Console.WriteLine("The number is divisible by 6");
}
else if (numberInputed % 3 == 0)
{
    Console.WriteLine("The number is divisible by 3");
}
else if (numberInputed % 2 == 0)
{
    Console.WriteLine("The number is divisible by 2");
}
else
{
    Console.WriteLine("Not divisible");
}