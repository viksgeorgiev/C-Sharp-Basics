namespace _04.Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string threeDigitNumber = Console.ReadLine();

            int[] digits = threeDigitNumber.ToCharArray().Select(x=>x.ToString()).Select(int.Parse).ToArray();

            int digit1 = digits[0];
            int digit2 = digits[1];
            int digit3 = digits[2];

            int option1 = digit1 * (digit2 + digit3);
            int option2 = (digit1 + digit2) * digit3;
            int option3 = digit1 + (digit2 * digit3);
            int option4 = digit1 * digit2 * digit3;
            int option5 = digit1 + digit2 + digit3;

            
            int maxResult = Math.Max(option1, Math.Max(option2, Math.Max(option3, Math.Max(option4, option5))));

            Console.WriteLine(maxResult);
        }
    }
}
