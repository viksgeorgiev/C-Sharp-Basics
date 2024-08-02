
int inputN = int.Parse(Console.ReadLine());

Console.WriteLine(GetFibonacci(inputN));

static int GetFibonacci(int inputN)
{
    if (inputN == 1 || inputN == 2 || inputN == 0)
    {
        return 1;
    }
    else
    {
       return GetFibonacci(inputN - 1) + GetFibonacci(inputN - 2);
    }
}

