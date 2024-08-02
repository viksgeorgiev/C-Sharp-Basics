int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

int[] arrayTop  = new int[array.Length];
bool isItBigger = false;

for (int i = 0; i < array.Length; i++)
{
    isItBigger = false;

    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] > array[j])
        {
            isItBigger = true;
        }
        else 
        {
            isItBigger = false;

            if (i == array.Length - 1)
            {
                isItBigger = true;
            }

            break;
        }
    }

    if (isItBigger) 
    {
        arrayTop[i] = array[i];
    }
}

for (int i = 0; i < arrayTop.Length ; i++)
{
    if (arrayTop[i] != 0)
    {
        Console.Write($"{arrayTop[i]} ");
    }
}