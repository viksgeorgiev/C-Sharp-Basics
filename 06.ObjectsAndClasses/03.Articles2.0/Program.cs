namespace _03.Articles2._0
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

        
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                List<string> articleInput = Console.ReadLine().Split(", ").ToList();

                string title = articleInput[0];
                string content = articleInput[1];
                string author = articleInput[2];


                Article article = new Article(title, content, author);

                
                articles.Add(article); 
            }



            foreach (var article in articles) 
            {
                Console.WriteLine(article.ToString());
            }

            
        }
    }


}
