
int lines = int.Parse(Console.ReadLine());
nint sumOfDigits = 0;

for (int i = 0; i < lines; i++)
{
    nint[] numbers = Console.ReadLine().Split().Select(nint.Parse).ToArray();
    if (numbers[0] > numbers[1])
    {
        sumOfDigits = 0;

        //string number = numbers[0].ToString();
        //for (int j = 0; j < number.Length; j++)
        //{
        //    sumOfDigits += double.Parse(number[j].ToString());
        //}
        numbers[0] = Math.Abs(numbers[0]);
        foreach (char c in numbers[0].ToString())
        {
            sumOfDigits += c - '0';
        }
    }
    else if (numbers[0] <= numbers[1] )
    {
        sumOfDigits = 0;
        numbers[1] = Math.Abs(numbers[1]);
        //string number = numbers[1].ToString();
        //for (int j = 0; j < number.Length; j++)
        //{
        //    sumOfDigits += double.Parse(number[j].ToString());
        //}
        foreach (char c in numbers[1].ToString())
        {
            sumOfDigits += c - '0';
        }

    }
    Console.WriteLine(sumOfDigits);
}

