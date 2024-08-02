

int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int numberK = input.Length / 4;

int[] upperRow = new int[2 * numberK];
int[] lowerRow = new int[2 * numberK];

int[] firstHalfTopRow = new int[numberK];
int[] secondHalfOfTopRow = new int[numberK];

int[] result = new int[2 * numberK];

for (int i = 0; i < numberK; i++)
{
    firstHalfTopRow[i] = input[i];
}

int index = 0;

for (int i = input.Length - numberK; i < input.Length; i++)
{
    secondHalfOfTopRow[index] = input[i];
    index++;
}

Array.Reverse(firstHalfTopRow);
Array.Reverse(secondHalfOfTopRow);

upperRow = firstHalfTopRow.Concat(secondHalfOfTopRow).ToArray();

index = 0;

for (int i = numberK; i < input.Length - numberK; i++)
{
    lowerRow[index] = input[i];
    index++;
}


//Console.WriteLine(string.Join(" ",firstHalfTopRow));
//Console.WriteLine(string.Join(" ",secondHalfOfTopRow));
//Console.WriteLine(string.Join(" ",upperRow));
//Console.WriteLine(string.Join(" ",lowerRow));

for (int i = 0; i < result.Length; i++)
{
    result[i] = upperRow[i] + lowerRow[i];
}

Console.WriteLine(string.Join(" ", result));