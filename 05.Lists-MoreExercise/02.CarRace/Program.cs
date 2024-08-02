namespace _02.CarRace
{

    internal class Program
    {
        public static double SumOfPaths(List<double> paths)
        {
            double sum = 0;
            foreach (double step in paths)
            {
                if (step != 0)
                {
                    sum += step;
                }
                else
                {
                    sum *= 0.8;
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            List<double> race = Console.ReadLine().Split(" ").Select(double.Parse).ToList();

            List<double> leftRacer = race.GetRange(0, race.Count / 2);
            List<double> righttRacer = race.GetRange(race.Count / 2 + 1, race.Count / 2);
            List<double> righttRacerReversed = new List<double>();
            righttRacer.Reverse();
            righttRacerReversed.AddRange(righttRacer);
            

            double leftScore = SumOfPaths(leftRacer);
            double rightScore = SumOfPaths(righttRacerReversed);

            if (leftScore > rightScore) 
            {
                Console.WriteLine($"The winner is right with total time: {rightScore:#.#}");
            }
            else if (rightScore > leftScore) 
            {
                Console.WriteLine($"The winner is left with total time: {leftScore:#.#}");
            }
        }
        
    }
}
