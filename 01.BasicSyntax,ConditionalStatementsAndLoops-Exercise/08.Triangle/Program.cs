﻿int inputN = int.Parse(Console.ReadLine());

for (int i = 1; i <= inputN; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}