using MedClaimX.Core.Common;
using MedClaimX.Core.Identity;
using MedClaimX.Core.Management;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedClaimX.Infrastructure.Persistence
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentObject> DocumentObjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Claim Address Configs
            modelBuilder.Entity<Claim>().OwnsOne(c => c.PrimaryAddress, a =>
            {
                a.OwnsOne(p => p.GeoLocation);
            });

            modelBuilder.Entity<Claim>().OwnsOne(c => c.SecondaryAddress, a =>
            {
                a.OwnsOne(p => p.GeoLocation);
            });

            // Organization Address Configs
            modelBuilder.Entity<Organization>().OwnsOne(o => o.PrimaryAddress, a =>
            {
                a.OwnsOne(p => p.GeoLocation);
            });

            modelBuilder.Entity<Organization>().OwnsOne(o => o.SecondaryAddress, a =>
            {
                a.OwnsOne(p => p.GeoLocation);
            });
        }
    }
}
