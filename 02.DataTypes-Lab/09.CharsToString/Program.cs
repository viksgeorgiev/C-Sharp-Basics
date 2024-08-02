using System.Text;

namespace _09.CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 3; i++)
            {
                sb.Append(char.Parse(Console.ReadLine()));
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
