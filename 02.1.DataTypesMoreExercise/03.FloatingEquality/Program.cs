decimal numberA = decimal.Parse(Console.ReadLine());
decimal numberB = decimal.Parse(Console.ReadLine());

decimal eps = 0.000001m;


decimal difference = Math.Abs(numberA) - Math.Abs(numberB);

difference = Math.Abs(difference);

if (difference >= eps)
{
    Console.WriteLine("False");
}
else
{
    Console.WriteLine("True");
}