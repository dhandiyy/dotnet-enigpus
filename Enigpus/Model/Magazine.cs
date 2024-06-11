namespace Enigpus.Model;

public class Magazine : Book
{
    public Magazine(string code, string title, string publisher, int year) : base(code, title, publisher, year)
    {
        
    }

    public override string GetTitle()
    {
        return Title;
    }
}