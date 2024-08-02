using System.Text.RegularExpressions;

namespace M00.EmailValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string pattern = @"([A-Za-z0-9._-]+)@([A-Za-z]+)\.[A-Za-z]{2,6}\b";

                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
        }
    }
}
