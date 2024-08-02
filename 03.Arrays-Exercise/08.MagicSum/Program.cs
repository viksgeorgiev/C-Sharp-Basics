int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int magicNumebr = int.Parse(Console.ReadLine());

string pairs = string.Empty;

for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[i] + numbers[j] == magicNumebr)
        {
            Console.Write($"{numbers[i]} {numbers[j]}");
            Console.WriteLine();
        }
    }
}
