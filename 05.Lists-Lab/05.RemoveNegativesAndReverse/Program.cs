namespace _05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int i = 0;
            while (i < list.Count) 
            {
                if (list[i] < 0)
                {
                    list.RemoveAt(i);
                    i = 0;
                }
                else
                {
                    i++;
                }
            }
            if (list.Count == 0) 
            {
                Console.WriteLine("empty");
            }
            else
            {
                list.Reverse();
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}
