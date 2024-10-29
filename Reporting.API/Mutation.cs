
namespace Reporting.API;

public class Mutation
{
    public async Task<Author> AddAuthor(ApplicationDBContext dbContext, string name)
    {
        var author = new Author(Guid.NewGuid(), name);
        await dbContext.Authors.AddAsync(author);
        await dbContext.SaveChangesAsync();
        
        return author;
    }
    
    public async Task<Book> AddBook(ApplicationDBContext dbContext, string title, Guid authorId)
    {
        var author = await dbContext.Authors.FindAsync(authorId);
        if(author is null)
            throw new ApplicationException($"Author with id {authorId} not found");

        var book = new Book(Guid.NewGuid(), title, authorId)
        {
            Author = author
        };
        
        await dbContext.Books.AddAsync(book);
        await dbContext.SaveChangesAsync();
        
        return book;
    }   
}