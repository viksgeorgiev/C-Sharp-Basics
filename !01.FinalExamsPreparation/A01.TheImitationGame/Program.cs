using System.Text;

namespace A01.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            StringBuilder sb_encryptedMessage = new StringBuilder(encryptedMessage);

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] commands = input.Split("|").ToArray();

                if (commands[0] == "Move")
                {
                    int numberOfLetters = int.Parse(commands[1]);
                    sb_encryptedMessage.Append((sb_encryptedMessage.ToString()).Substring(0,numberOfLetters));
                    sb_encryptedMessage.Remove(0, numberOfLetters);
                }
                if (commands[0] == "Insert")
                {
                    int index = int.Parse(commands[1]);
                    string value = commands[2];

                    sb_encryptedMessage.Insert(index, value);
                }
                if (commands[0] == "ChangeAll")
                {
                    string substring = commands[1];
                    string replacement = commands[2];
                    sb_encryptedMessage.Replace(substring, replacement);
                }
            }

            Console.WriteLine($"The decrypted message is: {sb_encryptedMessage.ToString()}");
        }
    }
}
