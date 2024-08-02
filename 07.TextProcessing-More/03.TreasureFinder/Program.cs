using System.Text;

namespace _03.TreasureFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "find") 
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < input.Length; i++)
                {
                    
                    int indexForKey = i % key.Length;
                    sb.Append((char)(input[i] - key[indexForKey]));
                }
                string sbCasted = sb.ToString();
               
                int indexStartType = sbCasted.IndexOf('&');
                int indexEndType = sbCasted.LastIndexOf('&');

                int indexCoordinatesStart = sbCasted.IndexOf('<');
                int indexCoordinatesEnd = sbCasted.IndexOf('>');

                string type = sbCasted.Substring(indexStartType + 1, indexEndType - indexStartType - 1);
                string coordinates = sbCasted.Substring(indexCoordinatesStart + 1, indexCoordinatesEnd - indexCoordinatesStart - 1);

                Console.WriteLine($"Found {type} at {coordinates}");
            }
        }
    }
}
