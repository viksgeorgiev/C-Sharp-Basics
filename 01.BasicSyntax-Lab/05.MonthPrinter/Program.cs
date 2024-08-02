using System.Text;

namespace _05.MonthPrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());

            string[] months = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            if (month < 1 || month > 12)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine(months[month-1]);
            }
        }
    }
}
