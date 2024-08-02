namespace _04.MixedUpLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> firstList = Console.ReadLine().Split(" ").Select(double.Parse).ToList();
            List<double> secondList = Console.ReadLine().Split(" ").Select(double.Parse).ToList();

            secondList.Reverse();

            List<double> range = new List<double>();
            

            if (firstList.Count > secondList.Count)
            {
                range.Add(firstList[firstList.Count - 1]);
                range.Add(firstList[firstList.Count - 2]);
                firstList.RemoveRange(firstList.Count - 2, 2);
            }
            else
            {
                range.Add(secondList[secondList.Count - 1]);
                range.Add(secondList[secondList.Count - 2]);
                secondList.RemoveRange(secondList.Count - 2, 2);
            }

            range.Sort();

            List<double> mixingList = new List<double>();

            for (int i = 0; i < firstList.Count; i++)
            {
                mixingList.Add(firstList[i]);
                mixingList.Add(secondList[i]);
            }

            List<double> listToPrint = new List<double>();

            foreach (double number in mixingList)
            {
                if (number > range[0] && number < range[1])
                {
                    listToPrint.Add(number);
                }
            }
            listToPrint.Sort();
            Console.WriteLine(string.Join(" ", listToPrint));
        }
    }
}
