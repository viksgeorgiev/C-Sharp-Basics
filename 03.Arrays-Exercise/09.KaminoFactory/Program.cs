namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dnaLenght = int.Parse(Console.ReadLine());

            int[] dna = new int[dnaLenght];

            string input;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                dna = input.Split("!",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                dna.
            }

        }
    }
}
