
double moneyJohn = double.Parse(Console.ReadLine());
double studentsCount = double.Parse(Console.ReadLine());
double lightSaberPrice  = double.Parse(Console.ReadLine());
double robesPrice = double.Parse(Console.ReadLine());
double beltsPrice  = double.Parse(Console.ReadLine());


double additionalSabers = Math.Ceiling(studentsCount * 0.10);

double lightSabersCost = (studentsCount + additionalSabers) * lightSaberPrice;
double robesCost = studentsCount * robesPrice;
int freeBelts = (int)studentsCount / 6;
double beltsCost = (studentsCount - freeBelts) * beltsPrice;

double allCosts = lightSabersCost + robesCost + beltsCost;

if (allCosts > moneyJohn)
{
    Console.WriteLine($" John will need {allCosts - moneyJohn:F2}lv more.");
}
else
{
    Console.WriteLine($"The money is enough - it would cost {allCosts:F2}lv.");
}
