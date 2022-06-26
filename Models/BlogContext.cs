using Microsoft.EntityFrameworkCore;

namespace blogApp.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Team> Teams { get; set; }  
    }
}
