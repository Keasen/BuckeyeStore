using Microsoft.EntityFrameworkCore;
using BuckeyeStore.Core;

namespace BuckeyeStore.Api.Data
{
    public class BuckeyeStoreContext : DbContext
    {
        public BuckeyeStoreContext() { }
        public BuckeyeStoreContext(DbContextOptions<BuckeyeStoreContext> options)
            : base(options) { }
        public DbSet<Product> Products {get; set; }
    }
}