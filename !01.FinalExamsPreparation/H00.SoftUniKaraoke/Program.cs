namespace H00.SoftUniKaraoke
{
    public class Singer
    {
        public string Name { get; set; }
        public List<string> Awards { get; set; }
        public Singer(string name)
        {
            Name = name;
            Awards = new List<string>();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> participantsList = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> songList = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string, Singer> dictOfSingers = new Dictionary<string, Singer>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "dawn")
            {
                string[] inputData = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string performer = inputData[0];
                string song = inputData[1];
                string award = inputData[2];

                if (!(participantsList.Contains(performer) && songList.Contains(song)))
                {
                    continue;
                }
                else
                {
                    if (!dictOfSingers.Keys.Contains(performer))
                    {
                        Singer newSinger = new Singer(performer);
                        newSinger.Awards.Add(award);
                        dictOfSingers.Add(performer, newSinger);
                    }
                    else
                    {
                        if (dictOfSingers[performer].Awards.Contains(award))
                        {
                            continue;
                        }
                        dictOfSingers[performer].Awards.Add(award);
                    }
                }
            }

            Dictionary<string, Singer> sortedDictionaryForPrinting = dictOfSingers
                                            .OrderByDescending(aw => aw.Value.Awards.Count)
                                            .ThenBy(aw => aw.Value.Name)
                                            .ToDictionary(k => k.Key, v => v.Value);

            if (sortedDictionaryForPrinting.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (Singer singer in sortedDictionaryForPrinting.Values)
            {
                Console.WriteLine($"{singer.Name}: {singer.Awards.Count} awards");
                foreach (string award in singer.Awards)
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
