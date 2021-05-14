using Microsoft.EntityFrameworkCore;

namespace GuestBook.Models
{
    public class CommentContext : DbContext
    {
        public DbSet<Comments> Comments { get; set; }

        public CommentContext(DbContextOptions<CommentContext> options): base(options)
        {
            Database.Migrate();
        }
    }
}
