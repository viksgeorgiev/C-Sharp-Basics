
namespace _02.Article
{
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }


        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> articleInput = Console.ReadLine().Split(", ").ToList();

            string title = articleInput[0];
            string content = articleInput[1];
            string author = articleInput[2];

            Article article = new Article(title, content, author);

            int commands = int.Parse(Console.ReadLine());

            for (int i = 0; i < commands; i++)
            {
                List<string> commandsInput = Console.ReadLine().Split(" ").ToList();

                switch (commandsInput[0])
                {
                    case "Edit:":
                        commandsInput.RemoveAt(0);
                        article.Edit(string.Join(" ", commandsInput));
                        break;
                    case "ChangeAuthor:":
                        commandsInput.RemoveAt(0);
                        article.ChangeAuthor(string.Join(" ", commandsInput));
                        break;
                    case "Rename:":
                        commandsInput.RemoveAt(0);
                        article.Rename(string.Join(" ", commandsInput));
                        break;

                }
            }

            Console.WriteLine(article.ToString());
        }
    }


}
