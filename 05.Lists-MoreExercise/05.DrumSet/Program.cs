namespace _05.DrumSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());

            List<int> drumList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            List<int> startingConditionOfDrums = new List<int>(drumList);

            string input;



            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int powerStrucken = int.Parse(input);

                for (int i = 0; i < drumList.Count; i++)
                {
                    drumList[i] -= powerStrucken;

                    if (drumList[i] <= 0)
                    {
                        if (startingConditionOfDrums[i] * 3 > money)
                        {
                            drumList.RemoveAt(i);
                            startingConditionOfDrums.RemoveAt(i);
                            --i;
                        }
                        else 
                        {
                            drumList[i] = startingConditionOfDrums[i];
                            money -= drumList[i] * 3;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", drumList));
            Console.WriteLine($"Gabsy has {money:F2}lv.");

        }
    }
}

/*namespace _05.DrumSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            List<int> drumList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> startingConditionOfDrums = new List<int>(drumList);

            string input;
            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int powerStrucken = int.Parse(input);

                for (int i = 0; i < drumList.Count; i++)
                {
                    drumList[i] -= powerStrucken;

                    if (drumList[i] <= 0)
                    {
                        if (startingConditionOfDrums[i] * 3 > money)
                        {
                            drumList.RemoveAt(i);
                            startingConditionOfDrums.RemoveAt(i);
                            i--; // Adjust the index after removal to avoid skipping the next drum
                        }
                        else
                        {
                            money -= startingConditionOfDrums[i] * 3;
                            drumList[i] = startingConditionOfDrums[i];
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", drumList));
            Console.WriteLine($"Gabsy has {money:F2}lv.");
        }
    }
}*/