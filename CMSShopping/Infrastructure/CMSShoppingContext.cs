using Microsoft.EntityFrameworkCore;
using CMSShopping.Models;


namespace CMSShopping.Infrastructure
{
    public class CMSShoppingContext : DbContext
    {
        public CMSShoppingContext(DbContextOptions<CMSShoppingContext> options)
            :base(options)
        {
        }

        public DbSet<Page> Pages { get; set; } 
    }
}
