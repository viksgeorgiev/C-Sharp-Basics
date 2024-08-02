namespace _10.LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char inputChar = char.Parse(Console.ReadLine());

            if (Char.IsUpper(inputChar))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
