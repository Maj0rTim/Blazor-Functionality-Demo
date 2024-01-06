using Microsoft.EntityFrameworkCore;
using BlazorApp2.Models;

namespace BlazorApp2.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {
            
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }

}
