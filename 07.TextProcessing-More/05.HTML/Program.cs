using System.Text;

namespace _05.HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titleOfAnArticle = Console.ReadLine();
            string contentOfArticle = Console.ReadLine();

            List<string> stringsComments = new List<string>();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "end of comments")
            {
                stringsComments.Add(input);
            }

            Console.WriteLine($"<h1>\n    {titleOfAnArticle}\n</h1>");
            Console.WriteLine($"<article>\n    {contentOfArticle}\n</article>");
            foreach (string comment in stringsComments)
            {
                Console.WriteLine($"<div>\n    {comment}\n</div>");
            };
        }
    }
}

/*using System;
using System.Text.RegularExpressions;
using System.Text;

class Program
{
    static void Main()
    {
        // Read input
        string title = Console.ReadLine();
        string content = Console.ReadLine();

        // StringBuilder to store comments
        StringBuilder commentsBuilder = new StringBuilder();
        string inputLine;
        while ((inputLine = Console.ReadLine()) != "end of comments")
        {
            commentsBuilder.AppendLine(inputLine);
        }
        
        // Convert comments to a single string
        string comments = commentsBuilder.ToString();

        // Use Regex to generate HTML output
        string htmlOutput = GenerateHtmlWithRegex(title, content, comments);

        // Print the HTML output
        Console.WriteLine(htmlOutput);
    }

    static string GenerateHtmlWithRegex(string title, string content, string comments)
    {
        // Escape HTML special characters in title and content
        title = EscapeHtml(title);
        content = EscapeHtml(content);

        // Prepare the HTML template
        string htmlTemplate = $"<h1>{title}</h1>\n<article>{content}</article>\n";

        // Use Regex to match each comment and wrap it in <div> tags
        string commentsPattern = @"^.*$";
        string commentDivs = Regex.Replace(comments, commentsPattern, m => $"<div>{EscapeHtml(m.Value)}</div>", RegexOptions.Multiline);

        // Combine the template with the comments
        return htmlTemplate + commentDivs;
    }

    // Method to escape HTML special characters
    static string EscapeHtml(string input)
    {
        return input
            .Replace("&", "&amp;")
            .Replace("<", "&lt;")
            .Replace(">", "&gt;")
            .Replace("\"", "&quot;")
            .Replace("'", "&#39;");
    }
}*/