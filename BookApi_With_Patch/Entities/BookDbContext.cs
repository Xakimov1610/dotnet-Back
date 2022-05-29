using Microsoft.EntityFrameworkCore;

namespace BookApi_With_Patch.Entities;

public class BookDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }
}