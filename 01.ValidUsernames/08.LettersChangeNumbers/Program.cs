namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            decimal sum = 0;

            foreach (string number in inputNumbers)
            {
                char letterBefore = number[0];
                char letterAfter = number[number.Length - 1];
                int numberMiddle = int.Parse(number.Substring(1, number.Length - 2));

                decimal result = 0;

                if (char.IsUpper(letterBefore))
                {
                    result = (decimal)numberMiddle / (letterBefore - '@');
                }
                else if (char.IsLower(letterBefore))
                {
                    result = (decimal)numberMiddle * (letterBefore - 'a' + 1);
                }

                if (char.IsUpper(letterAfter))
                {
                    result -= (letterAfter - '@');
                }
                else if (char.IsLower(letterAfter))
                {
                    result += (letterAfter - 'a' + 1);
                }
                sum += result;
            }
            
            Console.WriteLine($"{sum:F2}");
        }
    }
}
