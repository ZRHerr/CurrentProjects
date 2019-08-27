using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QuickFix.Models
{
    public class ApplicationDBContent:DbContext
    {
        public ApplicationDBContent(): base("QuickFix")
        {

        }
        public DbSet<User>Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Reply> Replies { get; set; }



    }
}