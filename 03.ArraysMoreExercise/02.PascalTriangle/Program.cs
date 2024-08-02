using System.Numerics;

BigInteger lines = int.Parse(Console.ReadLine());

if (lines == 0)
{
    Console.WriteLine(1);
}
else
{
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            BigInteger x = GetPasVal(i, j);
            Console.Write($"{x} ");
        }
        Console.WriteLine();
    }
}


    static BigInteger GetPasVal(int row, int col)
    {
    BigInteger factOfRow = Factorial(row);
    BigInteger factOfCol = Factorial(col);
    BigInteger factOfRowMinusCol = Factorial(row - col);
    BigInteger result = factOfRow / (factOfCol * factOfRowMinusCol);
        return result;
    }

    static BigInteger Factorial(int n)
    {
    BigInteger result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }


/*
 int lines = int.Parse(Console.ReadLine());
        
        if (lines == 0)
        {
            Console.WriteLine(1);
            return;
        }

        long[] currentRow = new long[lines + 1];

        for (int i = 0; i < lines; i++)
        {
            currentRow[0] = 1;
            Console.Write("1 ");

            for (int j = i; j > 0; j--)
            {
                currentRow[j] = currentRow[j] + currentRow[j - 1];
            }

            for (int k = 1; k <= i; k++)
            {
                Console.Write($"{currentRow[k]} ");
            }

            Console.WriteLine();
 
 */