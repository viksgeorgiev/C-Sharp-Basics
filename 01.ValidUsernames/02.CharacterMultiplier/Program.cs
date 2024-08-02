namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            string str1 = input[0];
            string str2 = input[1];

            int multiplied = 0;

            string longerInput = str1.Length > str2.Length ? str1 : str2;
            string shorterInput = str1.Length < str2.Length ? str1 : str2;

            if (str2.Length != str1.Length)
            {
                for (int i = 0; i < shorterInput.Length; i++)
                {
                    multiplied += shorterInput[i] * longerInput[i];
                }
                for (int j = shorterInput.Length; j < longerInput.Length; j++)
                {
                    multiplied += longerInput[j];
                }
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    multiplied += str1[i] * str2[i];
                }
            }

            Console.WriteLine(multiplied);
        }
    }
}
