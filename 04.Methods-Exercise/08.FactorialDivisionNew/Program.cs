

int num1 = int.Parse(Console.ReadLine());
int num2  = int.Parse(Console.ReadLine());

double division = FactorialFromInteger(num1)/ FactorialFromInteger(num2);

Console.WriteLine($"{division:F2}");

double FactorialFromInteger(int number)
{
    double factorial = 1;

    for (int i = number; i >= 1; i--)
    {
        factorial *= i;
    }
    return factorial;
}