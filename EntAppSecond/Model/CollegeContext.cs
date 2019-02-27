using Microsoft.EntityFrameworkCore;

namespace EntAppSecond_NS.Model
{
    public class CollegeContext : DbContext
    {
        public CollegeContext(DbContextOptions<CollegeContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
