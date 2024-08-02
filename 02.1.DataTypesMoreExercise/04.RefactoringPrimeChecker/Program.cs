int input = int.Parse(Console.ReadLine());
for (int i = 2; i <= input; i++)
{
    bool isItPrime = true;
    for (int divisor = 2; divisor < i; divisor++)
    {
        if (i % divisor == 0)
        {
            isItPrime = false;
            break;
        }
    }

    if (isItPrime)
    {
        Console.WriteLine($"{i} -> true");
    }
    else
    {
        Console.WriteLine($"{i} -> false");
    }
    //Console.WriteLine("{0} -> {1}", i, isItPrime);
}
