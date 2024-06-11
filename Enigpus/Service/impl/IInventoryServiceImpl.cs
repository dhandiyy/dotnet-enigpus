using Enigpus.Model;

namespace Enigpus.Service.impl;

public class IInventoryServiceImpl : IInventoryService
{
    private List<Book> inventory;

    public  IInventoryServiceImpl() => inventory = new List<Book>();

    public void AddBook(Book book)
    {
        inventory.Add(book);
    }
    public Book SearchBook(string title) => inventory.FirstOrDefault(book => book.Title.ToLower() == title.ToLower());
    public List<Book> GetAllBook() => inventory;
}