﻿namespace _10.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{theInteger} X {i} = {theInteger * i}");
            }
        }
    }
}
