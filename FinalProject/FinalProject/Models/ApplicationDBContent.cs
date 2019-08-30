using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class ApplicationDBContent:DbContext
    {
        public ApplicationDBContent() : base("FinalProject")
        {

        }
        public DbSet<Customer> Users { get; set; }
        public DbSet<Chat> Messages { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Parts> Parts { get; set; }
        public DbSet<Reviews> Review { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Vehicles> Vehicles { get; set; }
    }
}