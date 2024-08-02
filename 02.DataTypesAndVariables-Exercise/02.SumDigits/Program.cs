int number = int.Parse(Console.ReadLine());

int sum = 0;
int length = number.ToString().Length;
for (int i = 1; i <= length; i++)
{
    sum += number % 10;
    number /= 10;
}

Console.WriteLine(sum);