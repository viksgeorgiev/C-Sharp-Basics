using System.Text;

namespace _07.ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < 3; i++) 
            {
                list.Add(Console.ReadLine());
            }
            Console.WriteLine($"{list[0]}{list[2]}{list[1]}");
        }
    }
}
