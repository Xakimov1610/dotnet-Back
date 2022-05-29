using BookApi_With_Patch.Entities;

namespace BookApi_With_Patch.Service;

public interface IBookService
{
    Task<Book> GetByIdAsync(Guid id);
    Task<List<Book>> GetAllAsync();
    Task<Book> CreateAsync(Book bookToCreate);
    Task<Book> UpdateAsync(Book bookToUpdate);
    Task<Book> DeleteAsync(Guid id);
}