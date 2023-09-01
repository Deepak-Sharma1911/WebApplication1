using Microsoft.EntityFrameworkCore;
using WebApplication1.models;

namespace WebApplication1
{
    public class WebAppDbContext : DbContext
    {
        public WebAppDbContext(DbContextOptions contextOptions) : base(contextOptions)
        {

        }

        public DbSet<User> users { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
