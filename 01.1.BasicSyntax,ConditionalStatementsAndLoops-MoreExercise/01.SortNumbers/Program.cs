int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

int smallestNumber = int.MaxValue;
int biggestNumber = int.MinValue;
int middleNumber = 0;

if (num1 > num2 && num1 > num3)
{
    biggestNumber = num1;
    if (num2 > num3)
    {
        middleNumber = num2;
        smallestNumber = num3;
    }
    else
    {
        smallestNumber = num2;
        middleNumber = num3;
    }
}
else if (num2 > num1 && num2 > num3)
{
    biggestNumber = num2;
    if (num1 > num3)
    {
        middleNumber = num1;
        smallestNumber = num3;
    }
    else
    {
        smallestNumber = num1;
        middleNumber = num3;
    }
}
else if (num3 > num1 && num3 > num2)
{
    biggestNumber = num3;
    if (num2 > num1)
    {
        middleNumber = num2;
        smallestNumber = num1;
    }
    else
    {
        smallestNumber = num2;
        middleNumber = num1;
    }
}

Console.WriteLine(biggestNumber);
Console.WriteLine(middleNumber);
Console.WriteLine(smal);