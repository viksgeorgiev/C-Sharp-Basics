string[] arr = Console.ReadLine().Split().ToArray();

int rotations = int.Parse(Console.ReadLine());

rotations = rotations % arr.Length;

for (int i = 1; i <= rotations; i++)
{
    string firstElement = arr[0];
    for (int j = 0; j < arr.Length - 1; j++)
    {
        arr[j] = arr[j+1];
    }
    arr[arr.Length-1] = firstElement;
}

Console.WriteLine(string.Join(" ",arr));