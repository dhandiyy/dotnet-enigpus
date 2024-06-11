namespace Enigpus.Model;

public abstract class Book
{
    public string Code { get; set; }
    public string Title { get; set; }
    public string Publisher { get; set; }
    public int Year { get; set; }

    protected Book(string code, string title, string publisher, int year)
    {
        Code = code;
        Title = title;
        Publisher = publisher;
        Year = year;
    }

    public abstract string GetTitle();
}