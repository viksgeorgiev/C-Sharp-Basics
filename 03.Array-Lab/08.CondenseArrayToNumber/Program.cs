namespace _08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfIntegers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            while (arrayOfIntegers.Length != 1)
            {
                int[] condensed = new int[arrayOfIntegers.Length - 1];

                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = arrayOfIntegers[i] + arrayOfIntegers[i+1];
                }
                arrayOfIntegers = condensed;
            }
            Console.WriteLine(arrayOfIntegers[0]);
        }
    }
}
