namespace _05.AloneNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int target = int.Parse(Console.ReadLine());

            int[] indexedArray = new int[array.Length];

            Array.Copy(array, indexedArray, array.Length);

            while (Array.IndexOf(indexedArray, target) != -1)
            {
                int index = Array.IndexOf(indexedArray, target);
                if (target != 0) 
                {
                    indexedArray[index] = 0;
                }
                else
                {
                    indexedArray[index] = -1;
                }

                if (index < 1 || index > array.Length - 2)
                {
                    continue;
                }

                if (array[index - 1] != array[index] && array[index + 1] != array[index])
                {
                    array[index] = Math.Max(array[index - 1], array[index + 1]);
                }
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}//Correct code:
//using System;
//using System.Linq;
//
//namespace _05.AloneNumbers
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
//            int target = int.Parse(Console.ReadLine());
//
//            for (int i = 1; i < array.Length - 1; i++)
//            {
//                if (array[i] == target && array[i - 1] != target && array[i + 1] != target)
//                {
//                    array[i] = Math.Max(array[i - 1], array[i + 1]);
//                }
//            }
//
//            Console.WriteLine(string.Join(", ", array));
//        }
//    }
//}
/*Alone Numbers
We will give you array and a target! You need to find all "alone" elements in the array that match the given
target. These elements are alone if they have values before and after them, but those values are different from
them.
Return new version of the given array where every element that matches the target and is alone is replaced by
whichever value to its left or right is larger.
Input
Read from the standard input:
• The first line is the array with coma separated integer values -> 1,2,3
• The second line is the target that you should check against -> 2
Output
Print to the standard output:
One line of output - the changed array [1, 3,
please note that there is space after each coma.
Sample Tests
3]
Input
2
Output
3*/
