
int filler = int.Parse(Console.ReadLine());

MatrixNxN(filler);

void MatrixNxN(int filler)
{
    for (int i = 0; i < filler; i++)
    {
        for (int j = 0; j < filler; j++) 
        {
            Console.Write($"{filler} ");
        }
        Console.WriteLine();
    }
}