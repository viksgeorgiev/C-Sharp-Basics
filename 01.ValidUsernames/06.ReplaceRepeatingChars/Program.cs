﻿using System.Text;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i - 1] != input[i])
                {
                    sb.Append(input[i]);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
