using System.Text;

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ").ToArray();

            foreach(string username in usernames) 
            {
                if (!(username.Length >= 3 && username.Length <= 16))
                {
                    continue;
                }

                bool IsValidName = username.All(symbol => char.IsLetterOrDigit(symbol)
                || symbol == '-'
                || symbol == '_');

                if (IsValidName) 
                {
                    Console.WriteLine(username);
                }
            }            
        }
    }
}
