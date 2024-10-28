using Reporting.API.Models;
using Reporting.API.Services;

namespace Reporting.API;

public class Mutation
{
    public Book AddBook(BookService bookService, string title, string author)
    {
        var book = new Book(title, new Author(author));
        bookService.Books.Add(book);
        return book;
    }   
}