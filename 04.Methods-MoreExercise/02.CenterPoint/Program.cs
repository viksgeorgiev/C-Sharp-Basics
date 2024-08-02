

double X1 = double.Parse(Console.ReadLine());
double Y1 = double.Parse(Console.ReadLine());
double X2 = double.Parse(Console.ReadLine());
double Y2 = double.Parse(Console.ReadLine());




Console.WriteLine(CloserToCenter(X1, Y1, X2, Y2));

(double, double) CloserToCenter(double x1, double y1, double x2, double y2)
{
    double distanceToCenter1 = (X1 * X1) + (Y1 * Y1);
    double distanceToCenter2 = (X2 * X2) + (Y2 * Y2);

    if (distanceToCenter1 > distanceToCenter2)
    {
        return (X2, Y2);
    }
    else
    {
        return (X1, Y1);
    }
}