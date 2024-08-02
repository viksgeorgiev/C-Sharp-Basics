
namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split(" ");

                switch (commands[0])
                {
                    case "exchange":
                        array = Exchange(int.Parse(commands[1]), array);
                        break;
                    case "max":
                        MaxEvenOdd(commands[1], array);
                        break;
                    case "min":
                        MinEvenOdd(commands[1], array);
                        break;
                    case "first":
                        FirstEvenOdd(int.Parse(commands[1]), commands[2], array);
                        break;
                    case "last":
                        LastEvenOdd(int.Parse(commands[1]), commands[2], array);
                        break;
                }
            }
            Console.WriteLine($"[{string.Join(", ", array)}]");

        }

        private static void LastEvenOdd(int count, string type, int[] array)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            List<int> result = new List<int>();
            int parity = type == "even" ? 0 : 1;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 == parity)
                {
                    result.Insert(0, array[i]);
                    if (result.Count == count)
                        break;
                }
            }

            Console.WriteLine($"[{string.Join(", ", result)}]");
        }

        private static void FirstEvenOdd(int count, string type, int[] array)
        {
            {
                if (count > array.Length)
                {
                    Console.WriteLine("Invalid count");
                    return;
                }

                List<int> result = new List<int>();
                int parity = type == "even" ? 0 : 1;

                foreach (var num in array)
                {
                    if (num % 2 == parity)
                    {
                        result.Add(num);
                        if (result.Count == count)
                            break;
                    }
                }

                Console.WriteLine($"[{string.Join(", ", result)}]");
            }

        }

        private static void MinEvenOdd(string type, int[] array)
        {
            int parity = type == "even" ? 0 : 1;
            int minElement = int.MaxValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == parity && array[i] <= minElement)
                {
                    minElement = array[i];
                    index = i;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        private static void MaxEvenOdd(string type, int[] array)
        {
            int parity = type == "even" ? 0 : 1;
            int maxElement = int.MinValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == parity && array[i] >= maxElement)
                {
                    maxElement = array[i];
                    index = i;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        static int[] Exchange(int index, int[] array)
        {
            if (index < 0 || index >= array.Length)
            {
                Console.WriteLine("Invalid index");
                return array;
            }

            int[] firstHalf = array.Take(index + 1).ToArray();
            int[] secondHalf = array.Skip(index + 1).ToArray();

            return secondHalf.Concat(firstHalf).ToArray();
        }
    }
}
