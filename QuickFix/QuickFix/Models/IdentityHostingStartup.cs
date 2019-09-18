using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuickFix.Models;

[assembly: HostingStartup(typeof(QuickFix.Models.IdentityHostingStartup))]
namespace QuickFix.Models
{
    //herrera2097@gmail.com
    //password is P@ssword19
    //in order to access in development.
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDefaultIdentity<AppUser>()
                .AddEntityFrameworkStores<AppDbContext>();
            });
        }
    }
}