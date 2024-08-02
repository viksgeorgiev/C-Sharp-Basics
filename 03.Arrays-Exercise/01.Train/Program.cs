using System.Threading.Tasks.Dataflow;

int inputN = int.Parse(Console.ReadLine());

int[] passengers = new int[inputN];
int passengersCount = 0;

for (int i = 0; i < passengers.Length; i++)
{
    passengers[i] = int.Parse(Console.ReadLine());
    passengersCount += passengers[i];
}

Console.WriteLine(string.Join(" ",passengers));
Console.WriteLine(passengersCount);