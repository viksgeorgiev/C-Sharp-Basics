namespace _06.ThreeGroups
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            SortedDictionary<int, List<int>> dict = new();

            for (int i = 0; i < array.Length; i++) 
            {
                int moduled = array[i] % 3;
                if (dict.ContainsKey(moduled))
                {
                    dict[moduled].Add(array[i]);
                }
                else 
                {
                    dict[moduled] = new List<int> { array[i] };                  
                }
            }
            
            foreach (int moduled in dict.Keys)
            {
                Console.WriteLine($"{moduled}-> {String.Join(", ", dict[moduled])}");
            }
        }
    }
}
