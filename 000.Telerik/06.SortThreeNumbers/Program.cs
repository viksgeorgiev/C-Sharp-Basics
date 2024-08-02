namespace _06.SortThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] threeNumbers = new double[3];

            for (int i = 0; i < 3; i++)
            {
                threeNumbers[i] = double.Parse(Console.ReadLine());
            }
            double a = threeNumbers[0];
            double b = threeNumbers[1];
            double c = threeNumbers[2];

            double max = 0;
            double middle = 0;
            double min = 0;

            if (a >= b && a >= c)
            {
                if (b >= c) 
                {
                    max = a;
                    middle = b;
                    min = c;
                }
                else 
                {
                    max = a;
                    middle = c;
                    min = b;
                }
            }
            else if (b >= a && b >= c)
            {
                if (a >= c)
                {
                    max = b;
                    middle = a;
                    min = c;
                }
                else
                {
                    max = b;
                    middle = c;
                    min = a;
                }
            }
            else if (c >= b && c >= a)
            {
                if (b >= a)
                {
                    max = c;
                    middle = b;
                    min = a;
                }
                else
                {
                    max = c;
                    middle = a;
                    min = b;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(middle);
            Console.WriteLine(min);
        }
    }
}
