
namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list1 = Console.ReadLine().Split(" ").Select(double.Parse).ToList();
            List<double> list2 = Console.ReadLine().Split(" ").Select(double.Parse).ToList();
            List<double> merged = new List<double>();

            if (list1.Count != list2.Count)
            {
                merged = MergeLists(list1, list2, Math.Min(list1.Count, list2.Count));

                if (list1.Count > list2.Count)
                {
                    merged.AddRange(GetRemainingElements(list2.Count, list1));
                }
                else
                {
                    merged.AddRange(GetRemainingElements(list1.Count, list2));
                }
            }
            else
            {
                merged = MergeLists(list1, list2, Math.Min(list1.Count, list2.Count));               
            }

            Console.WriteLine(string.Join(" ", merged));
        }

        private static IEnumerable<double> GetRemainingElements(int count, List<double> list)
        {
            return list.GetRange(count, list.Count - count);
        }

        private static List<double> MergeLists(List<double> list1, List<double> list2, int count)
        {
            List<double> merged = new List<double>();
            for (int i = 0; i < count; i++)
            {
                merged.Add(list1[i]);
                merged.Add(list2[i]);
            }
            return merged;
        }
    }
}
