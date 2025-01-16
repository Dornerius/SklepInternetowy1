using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SklepIntranet.Models.CMS;
using SklepIntranet.Models.Shop;
using SklepIntranet.Models.Users;
using SklepIntranet.Models.Clients;
using SklepIntranet.Models.Finance;

namespace SklepIntranet.Data
{
    public class SklepIntranetContext : DbContext
    {
        public SklepIntranetContext (DbContextOptions<SklepIntranetContext> options)
            : base(options)
        {
        }

        public DbSet<SklepIntranet.Models.CMS.News> News { get; set; } = default!;
        public DbSet<SklepIntranet.Models.CMS.Page> Page { get; set; } = default!;
        public DbSet<SklepIntranet.Models.Shop.ProductType> ProductType { get; set; } = default!;
        public DbSet<SklepIntranet.Models.Shop.Product> Product { get; set; } = default!;
        public DbSet<SklepIntranet.Models.Users.Users> Users { get; set; } = default!;
        public DbSet<SklepIntranet.Models.Clients.Clients> Clients { get; set; } = default!;
        public DbSet<SklepIntranet.Models.Finance.Factures> Factures { get; set; } = default!;
    }
}
