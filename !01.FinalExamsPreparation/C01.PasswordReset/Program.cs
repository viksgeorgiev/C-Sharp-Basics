using System.Text;

namespace C01.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            StringBuilder sb = new StringBuilder(inputString);

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] commandsList = input.Split(" ").ToArray();

                string commandGiven = commandsList[0];

                if (commandGiven == "TakeOdd")
                {
                    string newString = string.Empty;
                    for (int i = 0; i < sb.Length; i++)
                    {
                        if (i % 2 == 1)
                        {
                            newString += sb[i];
                        }
                    }
                    sb = new StringBuilder(newString);
                    Console.WriteLine(sb.ToString());
                }
                if (commandGiven == "Cut")
                {
                    int index = int.Parse(commandsList[1]);
                    int length = int.Parse(commandsList[2]);

                    sb.Remove(index, length);
                    Console.WriteLine(sb.ToString());
                }
                if (commandGiven == "Substitute")
                {
                    string substring = commandsList[1];
                    string substitute = commandsList[2];

                    if (sb.ToString().Contains(substring))
                    {
                        sb.Replace(substring, substitute);
                        Console.WriteLine(sb.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }

            Console.WriteLine($"Your password is: {sb.ToString()}");
        }
    }
}
