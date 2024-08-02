using System;

namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            var tryCommand = AreIdentical(arr1,arr2);
            if (tryCommand.Item1 == true)
            {
                Console.WriteLine($"Arrays are identical. Sum: {tryCommand.Item2}");   
            }
            else if(tryCommand.Item1 == false)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {tryCommand.Item2} index");
            }
        }

        private static (bool,int) AreIdentical(int[] arr1, int[] arr2)
        {
            int index = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    index = i;
                    bool result = false;
                    return (result, index);
                }
            }
            return (true,arr1.Sum());
        }
    }
}
