using BookApi_With_Patch.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookApi_With_Patch.Service;

public class BookService : IBookService
{
    private readonly ILogger<BookService> _logger;
    private readonly BookDbContext _context;

    public BookService(ILogger<BookService> logger, BookDbContext context)
    {
        _logger = logger;
        _context = context;
    }
    
    public async Task  CreateAsync(Book bookToCreate)
    {
        await _context.Books.AddAsync(bookToCreate);
        await _context.SaveChangesAsync();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Book>> GetAllAsync()
        => await _context.Books.ToListAsync();

    public Task<Book> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Book> UpdateAsync(Book bookToUpdate)
    {
        throw new NotImplementedException();
    }

    Task IBookService.UpdateAsync(Book bookToUpdate)
    {
        throw new NotImplementedException();
    }
}
