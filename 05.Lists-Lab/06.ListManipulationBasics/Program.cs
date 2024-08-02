namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listToOperateOn = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split(" ").ToArray();

                if (commands[0] == "Add")
                {
                    AddNumber(int.Parse(commands[1]), listToOperateOn);
                }
                else if (commands[0] == "Remove")
                {
                    RemoveNumber(int.Parse(commands[1]), listToOperateOn);
                }
                else if (commands[0] == "RemoveAt")
                {
                    RemoveAt(int.Parse(commands[1]), listToOperateOn);
                }
                else if (commands[0] == "Insert")
                {
                    Insert(int.Parse(commands[1]), int.Parse(commands[2]), listToOperateOn);
                }
            }
            Console.WriteLine(string.Join(" ", listToOperateOn));

        }

        private static void Insert(int number, int index, List<int> listToOperateOn)
        {
            listToOperateOn.Insert(index, number);
        }

        private static void RemoveAt(int index, List<int> listToOperateOn)
        {
            listToOperateOn.RemoveAt(index);
        }

        private static void RemoveNumber(int number, List<int> listToOperateOn)
        {
            listToOperateOn.Remove(number);
        }

        private static void AddNumber(int number, List<int> listToOperateOn)
        {
            listToOperateOn.Add(number);
        }
    }
}
