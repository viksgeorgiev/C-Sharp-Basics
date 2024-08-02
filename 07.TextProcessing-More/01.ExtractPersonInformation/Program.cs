using System.Text;

namespace _01.ExtractPersonInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();

                int indexStartName = input.IndexOf('@');
                int indexEndName = input.IndexOf('|');

                int indexAgeStart = input.IndexOf('#');
                int indexAgeEnd = input.IndexOf('*');

                string name = input.Substring(indexStartName + 1, indexEndName - indexStartName - 1);
                string age = input.Substring(indexAgeStart + 1, indexAgeEnd - indexAgeStart - 1);

                Console.WriteLine($"{name} is {age} years old.");
            }
            
        }
    }
}
