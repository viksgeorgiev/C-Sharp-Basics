namespace _02.RepeatingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Too Slow have to be with dict look down for correct source code ::::
            int lines = int.Parse(Console.ReadLine());
            int[] ints = new int[lines];

            for (int i = 0; i < lines; i++) 
            {
                ints[i] = int.Parse(Console.ReadLine());
            }

            int number = 0;
            int occured = 0;

            
            for (int i = 0;i < ints.Length;i++) 
            {
                int found = 0;
                foreach (int c in ints) 
                {
                    if (c == ints[i])
                    {
                        found++;
                    }
                }

                if (found > occured)
                {
                    occured = found;
                    number = ints[i];
                }
                else if (found == occured)
                {
                    if (ints[i] < number)
                    {
                        number = ints[i];
                    }
                }
            }
            Console.WriteLine($"Number is: {number}");
        }
    }
}
/*using System;
using System.Collections.Generic;

namespace _02.RepeatingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] ints = new int[lines];

            for (int i = 0; i < lines; i++) 
            {
                ints[i] = int.Parse(Console.ReadLine());
            }

            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (var num in ints)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency[num] = 1;
                }
            }

            int number = 0;
            int maxOccurrence = 0;

            foreach (var kvp in frequency)
            {
                if (kvp.Value > maxOccurrence || (kvp.Value == maxOccurrence && kvp.Key < number))
                {
                    maxOccurrence = kvp.Value;
                    number = kvp.Key;
                }
            }

            Console.WriteLine(number);
        }
    }
}*/