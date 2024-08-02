string inputNumber = Console.ReadLine();
int finalNumber = int.Parse(inputNumber);

int number = int.Parse(inputNumber);
int sumOfFactoriel = 0;

for (int i = 0; i < inputNumber.Length; i++)
{
    int digit = number % 10;
    number /= 10;
    int factoriel = 1;

    for (int j = 1; j <= digit; j++)
    {
        factoriel *= j;
    }
    sumOfFactoriel += factoriel;
}

if (sumOfFactoriel == finalNumber)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}