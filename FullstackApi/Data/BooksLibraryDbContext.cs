using FullstackApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FullstackApi.Data
{
    public class BooksLibraryDbContext : DbContext
    {
        public BooksLibraryDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Books> Books { get; set; }
    }
}
