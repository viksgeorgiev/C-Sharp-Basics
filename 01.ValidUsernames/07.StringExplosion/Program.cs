

using System.Text;

namespace string_explosion

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<char> chars = new List<char>();

            foreach (char symbol in input)
            {
                chars.Add(symbol);
            }

            StringBuilder newSb = new StringBuilder();
            int strength = 0;

            for (int i = 0; i < chars.Count; i++)
            {
                if (chars[i] != '>' && strength == 0)
                {
                    newSb.Append(chars[i]);
                    continue;
                }

                if (chars[i] == '>' && strength == 0)
                {
                    strength += int.Parse(chars[i + 1].ToString());
                    newSb.Append(chars[i]);
                    continue;
                }

                if (chars[i] == '>' && strength != 0)
                {
                    strength += int.Parse(chars[i + 1].ToString());
                    newSb.Append(chars[i]);
                    continue;
                }

                if (strength != 0)
                {
                    strength--;
                    continue;
                }
            }
            Console.WriteLine(newSb.ToString());
        }
    }
}
