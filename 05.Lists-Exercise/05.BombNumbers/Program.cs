
List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> bomb = Console.ReadLine().Split().Select(int.Parse).ToList();

int specialNumber = bomb[0];
int power = bomb[1];

while (sequence.Contains(specialNumber))
{
    int position = sequence.IndexOf(specialNumber);
    
    int startLeft = Math.Max(position - power, 0);
    int countLeft = position - startLeft;



    int startRight = position + 1;
    int countRight = Math.Min(power, sequence.Count - startRight);

    sequence.RemoveRange(startRight, countRight);

    
    sequence.RemoveAt(position);

   
    sequence.RemoveRange(startLeft, countLeft);
}

int sum = 0;

foreach(int numb in sequence)
{
    sum += numb;
}

Console.WriteLine(sum);