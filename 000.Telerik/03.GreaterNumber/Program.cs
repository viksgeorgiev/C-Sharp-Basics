namespace _03.GreaterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

            int[] arrResult = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++) 
            {
                arrResult[i] = -1;
                for (int j = Array.IndexOf(arr2,arr1[i]) + 1; j < arr2.Length; j++) 
                {
                    if (arr1[i] < arr2[j])
                    {
                        arrResult[i] = arr2[j];
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(",", arrResult));
        }
    }
}
