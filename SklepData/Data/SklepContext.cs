using Microsoft.EntityFrameworkCore;
using SklepData.Data.CMS;
using SklepData.Data.Shop;
using SklepData.Data.Finance;

namespace SklepData.Data
{
    public class SklepContext : DbContext
    {
        public SklepContext (DbContextOptions<SklepContext> options)
            : base(options)
        {
        }

        public DbSet<News> News { get; set; } = default!;
        public DbSet<Page> Page { get; set; } = default!;
        public DbSet<ProductType> ProductType { get; set; } = default!;
        public DbSet<Product> Product { get; set; } = default!;
        public DbSet<SklepData.Data.Users.Users> Users { get; set; } = default!;
        public DbSet<SklepData.Data.Clients.Clients> Clients { get; set; } = default!;
        public DbSet<Factures> Factures { get; set; } = default!;
    }
}
