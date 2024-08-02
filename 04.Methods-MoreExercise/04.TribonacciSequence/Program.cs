
namespace _04.TribonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            for (int i = 1; i <= num; i++) 
            {
                Console.Write(TribonacciSequence(i)+ " ");
            }
            
        }

        static int TribonacciSequence(int num)
        {
            if (num == 1 || num == 2)
            {
                return 1;
            }
            else if (num == 3)
            {
                return 2;
            }
            else
            {
                int firstTribonacci = 1;
                int secondTribonacci = 1;
                int thirdTribonaci = 2;
                int currentTribonacci = 0;

                for (int i = 4; i <= num; i++)
                {
                    currentTribonacci = firstTribonacci + secondTribonacci + thirdTribonaci;
                    firstTribonacci = secondTribonacci;
                    secondTribonacci = thirdTribonaci;
                    thirdTribonaci = currentTribonacci;
                }

                return currentTribonacci;
            }
        }
    }
}
