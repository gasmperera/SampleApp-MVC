using Microsoft.EntityFrameworkCore;

namespace SampleApp.Models
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext(DbContextOptions<SchoolDBContext> options) : base(options)   
        {

        }

        public DbSet<Students> Students { get; set; }
    }
}
