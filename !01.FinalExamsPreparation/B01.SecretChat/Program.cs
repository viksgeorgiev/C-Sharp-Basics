using System.Text;

namespace B01.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            StringBuilder sb = new StringBuilder(message);

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] commands = input.Split(":|:").ToArray();
                string instruction = commands[0];

                if (instruction == "InsertSpace")
                {
                    int index = int.Parse(commands[1]);
                    sb.Insert(index, " ");
                    Console.WriteLine(sb.ToString());
                }
                if (instruction == "Reverse")
                {
                    string substring = commands[1];
                    if (sb.ToString().Contains(substring)) 
                    {
                        int index = sb.ToString().IndexOf(substring);
                        sb.Remove(index, substring.Length);
                        sb.Append(new string(substring.Reverse().ToArray()));
                        Console.WriteLine(sb.ToString());
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }    
                }
                if (instruction == "ChangeAll")
                {
                    string substring = commands[1];
                    string replacement = commands[2];

                    sb.Replace(substring, replacement);
                    Console.WriteLine(sb.ToString());
                }

            }
            Console.WriteLine($"You have a new text message: {sb.ToString()}");
        }
    }
}
