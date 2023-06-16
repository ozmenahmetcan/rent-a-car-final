using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentAPI.Domain.Entities;
using RentAPI.Domain.Entities.Common;
using RentAPI.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAPI.Persistence.Contexts
{
    public class RentAPIDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public RentAPIDbContext(DbContextOptions options) : base(options)
        {}
        public DbSet<Products> Products { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Domain.Entities.File> Files { get; set; }
        public DbSet<ProductImageFile> PrdocutImageFiles { get; set; }
        public DbSet<InvoiceFile> InvoiceFiles { get; set; }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker
                  .Entries<BaseEntity>();
              
            foreach (var data in datas)
            {
                _ = data.State switch
                {
                   EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                   EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                   _ => DateTime.UtcNow
                };
            }
            

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
