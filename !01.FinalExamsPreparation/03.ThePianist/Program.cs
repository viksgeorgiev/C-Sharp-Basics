namespace A03.ThePianist
{
    class Piece
    {
        public string Name { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }
        public Piece(string name, string composer, string key)
        {
            Name = name;
            Composer = composer;
            Key = key;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());

            Dictionary<string, Piece> dictOfPieces = new Dictionary<string, Piece>();

            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] input = Console.ReadLine().Split("|").ToArray();
                string pieceName = input[0];
                string composerName = input[1];
                string key = input[2];

                Piece newPiece = new Piece(pieceName, composerName, key);
                dictOfPieces.Add(pieceName, newPiece);
            }

            string inputConsole = string.Empty;

            while ((inputConsole = Console.ReadLine()) != "Stop")
            {
                string[] commands = inputConsole.Split("|").ToArray();

                if (commands[0] == "Add")
                {
                    string piece = commands[1];
                    string composer = commands[2];
                    string key = commands[3];

                    if (dictOfPieces.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else 
                    {
                        Piece newPiece = new Piece(piece, composer, key);
                        dictOfPieces.Add(piece, newPiece);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                }
                if (commands[0] == "Remove")
                {
                    string piece = commands[1];
                    if (dictOfPieces.ContainsKey(piece))
                    {
                        Console.WriteLine($"Successfully removed {piece}!");
                        dictOfPieces.Remove(piece);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                if (commands[0] == "ChangeKey")
                {
                    string piece = commands[1];
                    string key = commands[2];
                    if (dictOfPieces.ContainsKey(piece))
                    {
                        Console.WriteLine($"Changed the key of {piece} to {key}!");
                        dictOfPieces[piece].Key = key;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
            }

            foreach (Piece Piece in dictOfPieces.Values)
            {
                Console.WriteLine($"{Piece.Name} -> Composer: {Piece.Composer}, Key: {Piece.Key}");
            }
        }
    }
}
