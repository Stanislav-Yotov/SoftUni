using System;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine()
                                   .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Article article = new Article(line[0], line[1], line[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                string argument = cmdArgs[1];

                switch (command)
                {
                    case "Edit":
                        article.Edit(argument);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(argument);
                        break;
                    case "Rename":
                        article.Rename(argument);
                        break;
                }
            }
            Console.WriteLine(article.ToString());
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }
        public void Rename(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
