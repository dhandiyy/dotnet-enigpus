using Enigpus.Model;
using Enigpus.Service;
using Enigpus.Service.impl;

public class Program
{
    public static void Main(string[] args)
    {
        IInventoryService inventoryService = new IInventoryServiceImpl();
        
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Enigpus Library Inventory System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Search Book by Title");
            Console.WriteLine("3. View All Books");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddBookMenu(inventoryService);
                    break;
                case 2:
                    SearchBookMenu(inventoryService);
                    break;
                case 3:
                    ViewAllBooksMenu(inventoryService);
                    break;
                case 4:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine();
        }
    }

    public static void AddBookMenu(IInventoryService inventoryService)
    {
        Console.Write("""
                          1. Add Novel
                          2. Add Magazine
                          Choose an option: 
                          """);
        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Insert new book data");
        Console.Write("Code: ");
        string code = Console.ReadLine();
        
        Console.Write("Title: ");
        string title = Console.ReadLine();
        
        Console.Write("Publisher: ");
        string publisher = Console.ReadLine();
        
        Console.Write("Year: ");
        int year = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Author: ");
            string author = Console.ReadLine();
            Novel novel = new Novel(code, title, publisher, year, author);
            inventoryService.AddBook(novel);
            
            Console.WriteLine();
            Console.WriteLine("Book added successfully!");

        }
        
        else if (choice == 2)
        {
            Magazine magazine = new Magazine(code, title, publisher, year);
            inventoryService.AddBook(magazine);
            
            Console.WriteLine();
            Console.WriteLine("Book added successfully!");
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
        

    }

    public static void SearchBookMenu(IInventoryService inventoryService)
    {
        Console.Write("Enter Book Title to Search: ");
        string title = Console.ReadLine();

        Book book = inventoryService.SearchBook(title);
        if (book != null)
        {
            Console.WriteLine("Book Found");
            Console.WriteLine($"Code: {book.Code}");
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Publisher: {book.Publisher}");
            Console.WriteLine($"Year: {book.Year}");
            if (book is Novel novel)
            {
                Console.WriteLine($"Author: {novel.Author}");
            }
        }
        else
        {
            Console.WriteLine("Book not found");
        }

    }

    public static void ViewAllBooksMenu(IInventoryService inventoryService)
    {
        List<Book> books = inventoryService.GetAllBook();
        if (books.Count > 0)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Code: {book.Code}");
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Publisher: {book.Publisher}");
                Console.WriteLine($"Year: {book.Year}");
                if (book is Novel novel)
                {
                    Console.WriteLine($"Author: {novel.Author}");
                }
                Console.WriteLine();
                
            }
        }
        else
        {
            Console.WriteLine("No books available in the inventory.");

        }

    }
}