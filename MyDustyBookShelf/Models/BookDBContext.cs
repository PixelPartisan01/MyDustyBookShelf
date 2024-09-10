using Microsoft.EntityFrameworkCore;

namespace MyDustyBookShelf.Models
{
    public class BookDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDB");
        }
    }
}
