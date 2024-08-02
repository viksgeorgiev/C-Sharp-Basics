using System.Text.RegularExpressions;

namespace C02.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBarCodes = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < numberOfBarCodes; i++) 
            {
                string input = Console.ReadLine();

                string pattern = @"@#{1,}([A-Z][A-Za-z0-9]{4,}[A-Z])@#{1,}";
                if (Regex.IsMatch(input, pattern))
                {
                    string barcode = Regex.Match(input, pattern).Groups[1].Value;
                    string groupDigits = new string(barcode.Where(char.IsDigit).ToArray());
                    if (groupDigits.Length == 0 ) 
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {groupDigits}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
              
            }
        }
    }
}
