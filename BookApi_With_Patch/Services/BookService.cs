using BookApi_With_Patch.Entities;

namespace BookApi_With_Patch.Service;

public class BookService : IBookService
{
    public Task<Book> CreateAsync(Book bookToCreate)
    {
        throw new NotImplementedException();
    }

    public Task<Book> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Book>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Book> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Book> UpdateAsync(Book bookToUpdate)
    {
        throw new NotImplementedException();
    }
}
