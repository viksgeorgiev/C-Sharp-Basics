namespace K00.LibraryCatalog
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Copies { get; set; }

        public Book(string title, string author, int copies)
        {
            Title = title;
            Author = author;
            Copies = copies;
        }

        public override string ToString()
        {
            return $"{Title} by {Author}, Copies: {Copies}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, Book> dictOfBooks = new Dictionary<string, Book>();

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] parts = input.Split('"');
                string action = parts[0].Trim();
                string title = parts.Length > 1 ? parts[1].Trim() : string.Empty;
                string author = parts.Length > 3 ? parts[3].Trim() : string.Empty;
                int copies = parts.Length > 4 ? int.Parse(parts[4].Trim()) : 0;

                if (action == "AddBook")
                {
                    if (dictOfBooks.ContainsKey(title))
                    {
                        dictOfBooks[title].Copies += copies;
                    }
                    else
                    {
                        Book newBook = new Book(title, author, copies);
                        dictOfBooks.Add(title, newBook);
                    }
                }
                else if (action == "RemoveBook")
                {
                    if (dictOfBooks.ContainsKey(title))
                    {
                        dictOfBooks.Remove(title);
                    }
                }
                else if (action == "BorrowBook")
                {
                    if (dictOfBooks.ContainsKey(title))
                    {
                        if (dictOfBooks[title].Copies == 0)
                        {
                            Console.WriteLine("Book not available");
                        }
                        else
                        {
                            dictOfBooks[title].Copies--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Book not available");
                    }
                }
                else if (action == "ReturnBook")
                {
                    if (dictOfBooks.ContainsKey(title))
                    {
                        dictOfBooks[title].Copies++;
                    }
                }
                else if (action == "ListBooks")
                {
                    var sortedBooks = dictOfBooks.Values.OrderBy(book => book.Title);
                    foreach (Book book in sortedBooks)
                    {
                        Console.WriteLine(book);
                    }
                }
            }
        }
    }
}