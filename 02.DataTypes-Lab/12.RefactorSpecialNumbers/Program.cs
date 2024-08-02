namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
           
            int sum = 0;

            for (int character = 1; character <= range; character++)
            {
                int number = character;
                
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                bool isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}", character, isSpecialNumber);
                sum = 0;
            }

        }
    }
}
