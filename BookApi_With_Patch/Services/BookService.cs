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

    public async Task DeleteAsync(Guid id)
    {
        var book = await GetByIdAsync(id);
        if (book == null)
        {
            _logger.LogWarning("Book with id {id} not found", id);
            return;
        }
        _context.Books.Remove(book);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Book>> GetAllAsync()
        => await _context.Books.ToListAsync();

    public Task<Book> GetByIdAsync(Guid id)
        => _context.Books.FirstOrDefaultAsync(b => b.Id == id);

    public async Task<Book> UpdateAsync(Book bookToUpdate)
    {
        var book = await GetByIdAsync(bookToUpdate.Id);
        book.Name = bookToUpdate.Name;
        book.Title = bookToUpdate.Title;
        await _context.SaveChangesAsync();
        
    }

    Task IBookService.UpdateAsync(Book bookToUpdate)
    {
        throw new NotImplementedException();
    }
}
