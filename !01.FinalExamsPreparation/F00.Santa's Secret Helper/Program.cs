using System.Text.RegularExpressions;

namespace F00.Santa_s_Secret_Helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            List<string> listOfGoodKids = new List<string>();

            string input = string.Empty;
            
            while ((input = Console.ReadLine()) != "end")
            {
                string messageEncrypted = input;
                string messageDecrypted = string.Empty;

                foreach (char symbol in messageEncrypted)
                {
                    messageDecrypted += ((char)(symbol - key)).ToString();
                }

                string pattern = @"@(?<name>[A-Za-z]+)[^@\-\!\:\>]*!(?<behaviour>[NG])!";

                foreach (Match match in Regex.Matches(messageDecrypted, pattern))
                {
                    if (match.Success && match.Groups["behaviour"].Value == "G") 
                    {
                        listOfGoodKids.Add(match.Groups["name"].Value);
                    }
                }
            }

            foreach(string kid in listOfGoodKids)
            {
                Console.WriteLine(kid);
            }
        }
    }
}
