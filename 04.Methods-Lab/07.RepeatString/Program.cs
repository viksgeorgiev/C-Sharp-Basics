
using System.Text;

namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int timesRepeat = int.Parse(Console.ReadLine());

            Console.WriteLine(ReapeatString(inputString, timesRepeat));
        }

        private static string ReapeatString(string? inputString, int timesRepeat)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < timesRepeat; i++) 
            {
                sb.Append(inputString);
            }
            return sb.ToString();
        }
    }
}
