using System.Text;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int smallNumber = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            int carry = 0;
            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int number = int.Parse(bigNumber[i].ToString());

                number *= smallNumber;
                number += carry;

                sb.Insert(0, (number % 10).ToString());
                if (number > 9) 
                {
                    carry = number / 10;
                }
                else
                {
                    carry = 0;
                }
            }

            if (carry != 0)
            {
                sb.Insert(0, carry.ToString());
            }
            if(smallNumber != 0 && bigNumber != "0")
            {
                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
