using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WMB.Data.DataContext;
using WMB.Data.DataContext.DataAnalyst;

namespace WMB.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Beehive> Beehives { get; set; }
        public DbSet<ProductTypeCollection> ProductTypeCollections { get; set; }
        public DbSet<TypeBees> TypeBeess { get; set; }
        public DbSet<TypeHive> TypeHives { get; set; }

        public DbSet<EffectivenessHives> EffectivenessHivess { get; set; }

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
    }
}
