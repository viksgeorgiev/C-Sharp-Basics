using System;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace _01.WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string givenString = Console.ReadLine();
            StringBuilder sb = new StringBuilder(givenString);

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Travel")
            {
                string[] commands = input.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commands[0] == "Add Stop")
                {
                    int index = int.Parse(commands[1]);
                    string stringToAdd = commands[2];

                    if (CheckIndex(index))
                    {
                        sb.Insert(index, stringToAdd);
                    }
                    Console.WriteLine(sb.ToString());
                }
                if (commands[0] == "Remove Stop")
                {

                    int indexStart = int.Parse(commands[1]);
                    int indexEnd = int.Parse(commands[2]);
                    if (CheckIndex(indexStart) && CheckIndex(indexEnd))
                    {
                        sb.Remove(indexStart, Math.Abs(indexStart - indexEnd - 1));
                    }
                    Console.WriteLine(sb.ToString());
                }
                if (commands[0] == "Switch")
                {
                    string oldString = commands[1];
                    string newString = commands[2];
                    sb.Replace(oldString, newString);
                    Console.WriteLine(sb.ToString());
                }

            }

            Console.WriteLine($"Ready for world tour! Planned stops: {sb.ToString()}");

            bool CheckIndex(int index)
            {
                if (index >= 0 && index < sb.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


    }
}
