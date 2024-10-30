namespace Reporting.API;

public class Query
{
    [UseFiltering<BookFilterType>]
    public IQueryable<Book> GetBooks(ApplicationDBContext dbContext)
    {
        return dbContext.Books;
    }
    
    [UseFiltering]
    public IQueryable<Author> GetAuthors(ApplicationDBContext dbContext)
    {
        return dbContext.Authors;
    }
}