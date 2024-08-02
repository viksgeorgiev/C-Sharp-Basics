using System.Linq;

namespace _06.ForeignLanguages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<List<string>, string> dict = new Dictionary<List<string>, string>();
            dict.Add(new List<string>() { "England", "USA" }, "English");
            dict.Add(new List<string>() { "Spain", "Argentina", "Mexico" }, "Spanish");

            string inputLanguage = Console.ReadLine();

            foreach (var key in dict.Keys)
            {
                if (key.Contains(inputLanguage))
                {
                    Console.WriteLine(dict[key]);
                    return;
                }
            }
            Console.WriteLine("unknown");
        }
    }
}
