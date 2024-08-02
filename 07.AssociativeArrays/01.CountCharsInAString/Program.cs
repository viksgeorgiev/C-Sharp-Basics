
namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            List<char> listChar = inputString.Where(ch => ch != ' ').ToList();

            Dictionary<char, int> dictionaryOfChars = new();

            foreach (char ch in listChar) 
            {
                if (!dictionaryOfChars.ContainsKey(ch))
                {
                    dictionaryOfChars.Add(ch, 1);
                }
                else
                {
                    dictionaryOfChars[ch]++;
                }
            }

            foreach (var pair in dictionaryOfChars)
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }
}
