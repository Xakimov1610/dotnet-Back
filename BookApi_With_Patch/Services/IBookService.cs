using BookApi_With_Patch.Entities;

namespace BookApi_With_Patch.Service;

public interface IBookService
{
    Task<Book> GetByIdAsync(Guid id);
    Task<List<Book>> GetAllAsync();
    Task CreateAsync(Book bookToCreate);
    Task UpdateAsync(Book bookToUpdate);
    Task DeleteAsync(Guid id);
}