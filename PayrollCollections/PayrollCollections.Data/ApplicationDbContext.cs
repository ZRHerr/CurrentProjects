using Microsoft.EntityFrameworkCore;
using System;

namespace PayrollCollections.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
    
        public DbSet<Employee> Employees { get; set; }
    }
}
