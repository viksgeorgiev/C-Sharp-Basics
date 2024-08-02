namespace _06.ReversedChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[3];

            for (int i = 0; i < 3; i++)
            {
                chars[i] = char.Parse(Console.ReadLine());
            }

            Array.Reverse(chars);
            Console.WriteLine(string.Join(" ", chars));
        }
    }
}
