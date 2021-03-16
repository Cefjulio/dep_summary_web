using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infracstructure.Data
{
    public class StoreContext : DbContext
    {
        
        public StoreContext(DbContextOptions<StoreContext> options  ) : base
        (options)
        {

        }

        public DbSet<Account> Accounts { get; set; }

    }
}