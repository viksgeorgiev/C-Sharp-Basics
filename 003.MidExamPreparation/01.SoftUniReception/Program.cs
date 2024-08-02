int employee1 = int.Parse(Console.ReadLine());
int employee2 = int.Parse(Console.ReadLine());
int employee3 = int.Parse(Console.ReadLine());

int studentCount = int.Parse(Console.ReadLine());

int workForce = employee1 + employee2 + employee3;
int hours = 0;

while (studentCount > 0)
{
    hours++;
    if (hours % 4 == 0)
    {

    }
    else
    {
        studentCount -= workForce;
    }
}

Console.WriteLine($"Time needed: {hours}h.");