namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputPath = Console.ReadLine().Split(@"\");

            string lastEntrance = inputPath[inputPath.Length - 1];

            string[] fileNameAndExtension = lastEntrance.Split(".");

            Console.WriteLine($"File name: { fileNameAndExtension[0]}");
            Console.WriteLine($"File extension: {fileNameAndExtension[1]}");
        }
    }
}
