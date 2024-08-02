
int input = int.Parse(Console.ReadLine());

TopNumberCheck(input);
void TopNumberCheck(int input)
{

    for (int i = 0; i < input; i++)
    {
        int number = i;
        char[] digits = i.ToString().ToCharArray();

        int sumOfDigits = 0;
        bool isOdd = false;
        for (int j = 0; j < digits.Length; j++)
        {
            int digit = int.Parse(digits[j].ToString());

            if (digit % 2 == 1)
            {
                isOdd = true;
            }

            sumOfDigits += digit;
        }

        if ((sumOfDigits % 8 == 0) && isOdd)
        {
            Console.WriteLine(i);
        }
    }
}