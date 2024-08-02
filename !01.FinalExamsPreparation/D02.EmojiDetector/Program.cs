using System.Numerics;
using System.Text.RegularExpressions;

namespace D02.EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> emojisList = new List<string>();
            List<string> emojisWithDots = new List<string>();
            List<string> coolEmojis = new List<string>();

            int[] digits = input.Where(char.IsDigit)
                                       .Select(ch => int.Parse(ch.ToString()))
                                       .ToArray();

            BigInteger coolTreshhold = 1;
            foreach (int digit in digits)
            {
                coolTreshhold *= digit;
            }

            string pattern = @"(?<withdots>((::)|(\*\*))(?<emoji>[A-Z][a-z]{2,})\1)";

            foreach (Match matches in Regex.Matches(input, pattern))
            {
                emojisList.Add(matches.Groups["emoji"].Value);
                emojisWithDots.Add(matches.Groups["withdots"].Value);
            }

            for (int j = 0; j < emojisList.Count; j++)
            {
                int sumOfchars = 0;

                for (int i = 0; i < emojisList[j].Length; i++)
                {
                    sumOfchars += emojisList[j][i];
                }

                if (sumOfchars > coolTreshhold)
                {
                    coolEmojis.Add(emojisWithDots[j]);
                }

            }

            Console.WriteLine($"Cool threshold: {coolTreshhold}");
            Console.WriteLine($"{emojisList.Count} emojis found in the text. The cool ones are:");
            foreach(string emoji in coolEmojis)
            {
                Console.WriteLine(emoji);
            }

        }
    }
}