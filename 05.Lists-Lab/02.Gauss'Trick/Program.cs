namespace _02.Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split(" ").Select(double.Parse).ToList();

            for (int i = 0; i < list.Count / 2; i++)
            {
                list[i] += list[list.Count - 1 - i];
            }

            if (list.Count % 2 == 0)
            {
                list.RemoveRange(list.Count / 2, list.Count - list.Count / 2);
            }
            else
            {
                list.RemoveRange(list.Count / 2 + 1, list.Count - list.Count / 2 - 1);
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
