int numberOfPeopleN = int.Parse(Console.ReadLine());
int capacityP = int.Parse(Console.ReadLine());

int courses = (int)Math.Ceiling((double)numberOfPeopleN / capacityP);

Console.WriteLine(courses);