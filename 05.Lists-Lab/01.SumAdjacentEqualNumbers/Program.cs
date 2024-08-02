namespace _01.SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> listToSum = Console.ReadLine().Split(" ").Select(double.Parse).ToList();

            if (listToSum.Count == 0 ) 
            {
                Console.WriteLine("");
                return;
            }

            int i = 0;
            while (i < listToSum.Count - 1)
            {
                if (listToSum[i] == listToSum[i+1])
                {
                    listToSum[i] += listToSum[i + 1];
                    listToSum.RemoveAt(i+1);
                    i = 0;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(string.Join(" ", listToSum));
        }
    }
}
