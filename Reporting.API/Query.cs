namespace Reporting.API;

public class Query
{
    public IQueryable<Book> GetBooks(ApplicationDBContext dbContext)
    {
        return dbContext.Books;
    }
    
    public IQueryable<Author> GetAuthors(ApplicationDBContext dbContext)
    {
        return dbContext.Authors;
    }
}