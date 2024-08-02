

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

int sum = SumOfTwoIntegers(num1, num2);

int answer = SubstractSumFromIntegers(sum, num3);

static int SumOfTwoIntegers(int num1, int num2)
{
    int sum = num1 + num2;
    return sum;
}


static int SubstractSumFromIntegers(int sum, int subtractor)
{
    int substracted = sum - subtractor;
    return substracted;
}


Console.WriteLine(answer);
