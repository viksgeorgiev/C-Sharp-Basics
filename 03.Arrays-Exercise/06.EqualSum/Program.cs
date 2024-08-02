int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

bool exists = false;
int elementIndex = 0;

for (int i = 0; i < numbers.Length; i++)
{
    int leftSum = 0;
    int rightSum = 0;

    
    for (int j = i + 1; j < numbers.Length; j++)
    {
        rightSum += numbers[j];
    }

    for (int k = i - 1; k >= 0; k--)
    {
        leftSum += numbers[k];
    }

    if (i == 0 || i == numbers.Length - 1)
    {
        if (i == 0)
        {
            leftSum = 0;
        }
        else
        {
            rightSum = 0;
        }
    }

    if (rightSum == leftSum) 
    {
        exists = true;
        elementIndex = i;
        break;
    }
}

if (exists)
{
    Console.WriteLine(elementIndex);
}
else
{
    Console.WriteLine("no");
}