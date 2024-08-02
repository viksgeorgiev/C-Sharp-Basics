
int numberOfStudents = int.Parse(Console.ReadLine());
int numberOfLectures = int.Parse(Console.ReadLine());
int numberBonus = int.Parse(Console.ReadLine());

int studentAttendancies = 0;
double maxBonus = int.MinValue;
int maxAttenedLectures = 0;

double totalBonus = 0;

if (numberOfStudents == 0 || numberOfLectures == 0)
{
    Console.WriteLine($"Max Bonus: 0.");
    Console.WriteLine($"The student has attended 0 lectures.");
    return;
}

for (int i = 1; i <= numberOfStudents; i++)
{
    studentAttendancies = int.Parse(Console.ReadLine());
    totalBonus = (double)studentAttendancies / numberOfLectures * (5 + numberBonus);
    if (totalBonus > maxBonus)
    {
        maxBonus = totalBonus;
        maxAttenedLectures = studentAttendancies;
    }
}

Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
Console.WriteLine($"The student has attended {maxAttenedLectures} lectures.");


