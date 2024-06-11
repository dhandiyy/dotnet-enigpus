namespace Enigpus.Model;

public class Novel : Book
{
    public string Author { get; set; }

    public Novel(string code, string title, string publisher, int year, string author) : base(code, title, publisher, year)
    {
        Author = author;
    }

    public override string GetTitle()
    {
        return Title;
    }
}

    