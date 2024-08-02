namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrings = Console.ReadLine().Split(" ");

            Random random = new Random();

            for (int i = 0; i < inputStrings.Length; i++) 
            {
                int j = random.Next(0, inputStrings.Length);
                string temp = inputStrings[i];
                inputStrings[i] = inputStrings[j];
                inputStrings[j] = temp;
            }

            foreach (string word in inputStrings)
            {
                Console.WriteLine(word);
            }

        }
    }
}
