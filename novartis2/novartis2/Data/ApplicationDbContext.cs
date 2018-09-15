using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MSContext;
using novartis2.Models;

namespace novartis2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Account> accounts { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<ScAgentGoal> scAgentGoals { get; set; }
        public DbSet<ScAgent> ScAgents { get; set; }
        public DbSet<ScBrand> ScBrands { get; set; }
        public DbSet<ScHmo> ScHmos { get; set; }
        public DbSet<ScOrderProduct> ScOrderProducts { get; set; }
        public DbSet<ScOrder> ScOrders { get; set; }
        public DbSet<ScPharmacy> scPharmacies { get; set; }
        public DbSet<ScProduct> ScProducts { get; set; }
        public DbSet<ScWorkingDay> scWorkingDays { get; set; }
    }
}
