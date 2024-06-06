using BookReadingEventSystemDTO.Models;
using Microsoft.EntityFrameworkCore;

namespace BookReadingEventSystemDTO.Data
{
    public class BookReadingEventSystemContext : DbContext, IBookReadingEventSystemContext
    {
        public BookReadingEventSystemContext(DbContextOptions<BookReadingEventSystemContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Invitation> Invations { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Comment> Comments { get; set; }
    }
}
