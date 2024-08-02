
int input1 = int.Parse(Console.ReadLine());
int input2 = int.Parse(Console.ReadLine());
int input3 = int.Parse(Console.ReadLine());

SmallestOfThree(input1, input2, input3);
void SmallestOfThree(int input1, int input2, int input3)
{
    int smallest = int.MaxValue;
    if (input1 < smallest)
    {
        smallest = input1;
    }
    if (input2 < smallest) 
    {
        smallest = input2;
    }
    if (input3 < smallest) 
    {
        smallest = input3;
    }
    Console.WriteLine(smallest);
}