namespace _04.BackIn30Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes + 30 >= 60)
            {
                minutes = (60 - (60 - minutes + 30));
                hours++;
            }
            else
            {
                minutes += 30;
            }

            if (hours >= 24)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours:D1}:{minutes:D2}");
        }
    }
}
