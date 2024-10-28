using Reporting.API.Models;

namespace Reporting.API.Services;

public class BookService
{
    public ICollection<Book> Books { get; set; } = new List<Book>
    {
        new("Test", new Author("Alex"))
    };
}