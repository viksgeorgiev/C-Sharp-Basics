

List<double> input = new();

for (int i = 0; i < 8; i++)
{
    input.Add(double.Parse(Console.ReadLine()));
}

List<double> line1 = new();
List<double> line2 = new();

line1 = input.GetRange(0, 4);
line2 = input.GetRange(4, 4);

double line1Distance = GetDistanceD(line1);
double line2Distance = GetDistanceD(line2);

if (line1Distance < line2Distance)
{
    Console.WriteLine(CloserToCenter(line2[0], line2[1], line2[2], line2[3]));
}
else if (line1Distance > line2Distance)
{
    Console.WriteLine(CloserToCenter(line1[0], line1[1], line1[2], line1[3]));
}
else
{
    Console.WriteLine(CloserToCenter(line1[0], line1[1], line1[2], line1[3]));
}

double GetDistanceD(List<double> list)
{
    double distance = 0;

    distance = Math.Sqrt(Math.Pow((list[0] - list[2]), 2) + Math.Pow((list[1] - list[3]), 2));

    return distance;
}

string CloserToCenter(double x1, double y1, double x2, double y2)
{
    double distanceToCenter1 = (x1 * x1) + (y1 * y1);
    double distanceToCenter2 = (x2 * x2) + (y2 * y2);

    if (distanceToCenter1 > distanceToCenter2)
    {
        return $"({x2}, {y2})({x1}, {y1})";
    }
    else
    {
        return $"({x1}, {y1})({x2}, {y2})";
    }
}