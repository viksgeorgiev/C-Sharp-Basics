using System.Text;

namespace _04.MorseCodeTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>
        {
            { ".-", "A" },
            { "-...", "B" },
            { "-.-.", "C" },
            { "-..", "D" },
            { ".", "E" },
            { "..-.", "F" },
            { "--.", "G" },
            { "....", "H" },
            { "..", "I" },
            { ".---", "J" },
            { "-.-", "K" },
            { ".-..", "L" },
            { "--", "M" },
            { "-.", "N" },
            { "---", "O" },
            { ".--.", "P" },
            { "--.-", "Q" },
            { ".-.", "R" },
            { "...", "S" },
            { "-", "T" },
            { "..-", "U" },
            { "...-", "V" },
            { ".--", "W" },
            { "-..-", "X" },
            { "-.--", "Y" },
            { "--..", "Z" }          
        };


            string[] input = Console.ReadLine().Split("|").ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                string[] letters = input[i].Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                StringBuilder stringBuilder = new StringBuilder();
                foreach (string letter in letters)
                {
                    stringBuilder.Append(dict[letter]);
                }

                input[i] = stringBuilder.ToString();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
