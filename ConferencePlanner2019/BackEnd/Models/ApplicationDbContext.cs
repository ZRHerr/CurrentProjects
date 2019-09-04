using Microsoft.EntityFrameworkCore;

namespace BackEnd.Models
{
    /// <summary>
    /// this is the connection object for the database
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Speaker> Speakers { get; set; }
    }
}
