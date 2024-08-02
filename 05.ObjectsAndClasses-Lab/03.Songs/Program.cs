namespace _03.Songs
{
    public class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> list = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++) 
            {
                string[] input = Console.ReadLine().Split("_");
                Song song = new Song(input[0], input[1], input[2]);
                list.Add(song);
            }
            string lastLine = Console.ReadLine();
            if (lastLine == "all")
            {
                foreach (Song song in list) 
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in list)
                {
                    if (song.TypeList == lastLine)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
