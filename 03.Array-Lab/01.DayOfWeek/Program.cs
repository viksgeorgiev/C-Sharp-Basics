namespace _01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int dayInput = int.Parse(Console.ReadLine()) - 1;

            if (dayInput >= 0 && dayInput <= 6)
            {
                Console.WriteLine(daysOfWeek[dayInput]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }

}
