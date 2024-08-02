namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int theInteger = int.Parse(Console.ReadLine());
            int multiplyer = int.Parse(Console.ReadLine());

            if (multiplyer <= 10) 
            {
                for (int i = multiplyer; i <= 10; i++)
                {
                    Console.WriteLine($"{theInteger} X {i} = {theInteger * i}");
                }
            }
            else
            {
                Console.WriteLine($"{theInteger} X {multiplyer} = {theInteger * multiplyer}");
            }
        }
    }
}
