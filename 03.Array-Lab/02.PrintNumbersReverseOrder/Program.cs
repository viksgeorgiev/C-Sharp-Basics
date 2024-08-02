namespace _02.PrintNumbersReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersToReadFromSeparateLines = int.Parse(Console.ReadLine());

            int[] array = new int[numbersToReadFromSeparateLines];

            for (int i = 0; i < numbersToReadFromSeparateLines; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(array);
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
