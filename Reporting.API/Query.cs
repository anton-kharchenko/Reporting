namespace Reporting.API;

public class Query
{
    public Book GetBook()
    {
        return new Book("title", new Author("Anton Kharchenko"));
    }
}

public record Book(string Title, Author Author);

public record Author(string Name);