
namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();

            if (type == "int")
            {
                Console.WriteLine(GetMax(int.Parse(string1), int.Parse(string2)));
            }
            else if (type == "char")
            {
                Console.WriteLine(GetMax(char.Parse(string1), char.Parse(string2)));
            }
            else if (type == "string")
            {
                Console.WriteLine(GetMax(string1, string2));
            }


        }

        private static string GetMax(string string1, string string2)
        {
            int compare = string1.CompareTo(string2);
            if (compare > 0)
            {
                return string1;
            }
            else
            {
                return string2;
            }

        }

        private static int GetMax(int v1, int v2)
        {
            if (v1 == v2)
            {
                return v2;
            }
            return Math.Max(v1, v2);
        }
        private static char GetMax(char v1, char v2)
        {
            if (v1 > v2)
            {
                return v1;
            }
            else
            {
                return v2;
            }
        }
    }
}
