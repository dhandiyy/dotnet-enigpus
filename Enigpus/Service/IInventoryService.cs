using Enigpus.Model;

namespace Enigpus.Service;

public interface IInventoryService
{
    void AddBook(Book book);
    Book SearchBook(string title);
    List<Book> GetAllBook();
}