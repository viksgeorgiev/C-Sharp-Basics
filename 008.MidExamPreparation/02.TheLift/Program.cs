
int peopleWaiting = int.Parse(Console.ReadLine());

List<int> liftState = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

bool haveEmptySpaces = false;

for (int i = 0; i < liftState.Count; i++)
{
    if (liftState[i] < 4)
    {
        while(peopleWaiting > 0 && liftState[i] < 4 )
        {
            peopleWaiting--;
            liftState[i]++;
        }
    }
}


for (int i = 0; i < liftState.Count; i++)
{
    if (liftState[i] < 4)
    {
        haveEmptySpaces = true;
        break;
    }
}


if (peopleWaiting == 0 && haveEmptySpaces)
{
    Console.WriteLine("The lift has empty spots!");
    Console.WriteLine(string.Join(" ", liftState));
}
else if ( peopleWaiting > 0 && !haveEmptySpaces)
{
    Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
    Console.WriteLine(string.Join(" ", liftState));
}
else
{
    Console.WriteLine(string.Join(" ", liftState));
}
