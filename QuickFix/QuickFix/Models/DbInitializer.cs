using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickFix.Models
{
    public class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if(!context.services.Any())
            {
                context.AddRange
                    (new Services {ServiceType = "Oil Change", Description = "5W30 Full Synthetic", BasePrice = 32.95M, ServiceDate = DateTime.Now, CompletionDate = DateTime.Now, IsServiceDiscount = false},
                new Services {ServiceType = "Brake Pads", Description = "4 Pads 2 Rotors", BasePrice = 64.95M, ServiceDate = DateTime.Now, CompletionDate = DateTime.Now, IsServiceDiscount = false },
                new Services {ServiceType = "Alignment", Description = "Full Alignment with Tire Rotation", BasePrice = 42.95M, ServiceDate = DateTime.Now, CompletionDate = DateTime.Now, IsServiceDiscount = false },
                new Services {ServiceType = "Spark Plugs", Description = "6 plugs and 6 wires", BasePrice = 44.95M, ServiceDate = DateTime.Now, CompletionDate = DateTime.Now, IsServiceDiscount = false });
                context.SaveChanges();
            }
        }

    }
}
