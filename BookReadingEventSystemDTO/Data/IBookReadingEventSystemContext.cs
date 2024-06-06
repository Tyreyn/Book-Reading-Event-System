using BookReadingEventSystemDTO.Models;
using Microsoft.EntityFrameworkCore;

namespace BookReadingEventSystemDTO.Data
{
    public interface IBookReadingEventSystemContext
    {
        DbSet<Comment> Comments { get; set; }
        DbSet<Event> Events { get; set; }
        DbSet<Invitation> Invations { get; set; }
        DbSet<User> Users { get; set; }
    }
}