using Reporting.API.Models;
using Reporting.API.Services;

namespace Reporting.API;

public class Query
{
    public IEnumerable<Book> GetBooks(BookService bookService)
    {
        return bookService.Books;
    }
}