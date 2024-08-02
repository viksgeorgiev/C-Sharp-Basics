namespace _03.TakeSkipRope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> chars = new List<char>();
            foreach (var letter in input)
            {
                chars.Add(letter);
            }

            List<int> numbersList = new List<int>();
            List<string> nonNumbersList = new List<string>();

            foreach (var letter in chars)
            {
                if (letter >= '0' && letter <= '9')
                {
                    numbersList.Add(int.Parse(letter.ToString()));
                }
                else
                {
                    nonNumbersList.Add(letter.ToString());
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbersList[i]);
                }
                else
                {
                    skipList.Add(numbersList[i]);
                }
            }

            int currentIndex = 0;
            List<string> hiddenMessage = new List<string>();

            for (int i = 0; i < takeList.Count; i++)
            {
                int takeCount = takeList[i];
                int skipCount = skipList[i];

                
                if (currentIndex + takeCount > nonNumbersList.Count)
                {
                    takeCount = nonNumbersList.Count - currentIndex;
                }

                for (int j = 0; j < takeCount; j++)
                {
                    hiddenMessage.Add(nonNumbersList[currentIndex + j]);
                }

                currentIndex += takeCount + skipCount;
                
                if (currentIndex > nonNumbersList.Count)
                {
                    break;
                }
            }

            Console.WriteLine(string.Join("", hiddenMessage));
        }
    }
}


