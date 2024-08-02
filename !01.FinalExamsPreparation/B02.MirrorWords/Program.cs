using System.Data.SqlTypes;
using System.Text.RegularExpressions;

namespace B02.MirrorWords
{
    public class WordPairs
    {
        public string FirstWord { get; set; }
        public string SecondWord { get; set; }
        public WordPairs(string firstWord, string secondWord)
        {
            FirstWord = firstWord;
            SecondWord = secondWord;
        }
        public override string ToString()
        {
            return $"{FirstWord} <=> {SecondWord}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<WordPairs> pairs = new List<WordPairs>();
            List<WordPairs> omonyms = new List<WordPairs>();

            string pattern = @"([#@])([A-Za-z]{3,})\1\1([A-Za-z]{3,})\1";
    
            foreach (Match match in Regex.Matches(input, pattern))
            {
                string wordOne = match.Groups[2].Value;
                string wordTwo = match.Groups[3].Value;
                WordPairs newPair = new WordPairs(wordOne,wordTwo);
                pairs.Add(newPair);
            }

            foreach (WordPairs wordPair in pairs)
            {
                string secondWord = new string(wordPair.SecondWord.Reverse().ToArray());
                if (wordPair.FirstWord == secondWord)
                {
                    omonyms.Add(wordPair);
                }
            }

            if (pairs.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
                return;
            }
            else
            {
                Console.WriteLine($"{pairs.Count} word pairs found!");
            }

            if(omonyms.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", omonyms));
            }
        }
    }
}
