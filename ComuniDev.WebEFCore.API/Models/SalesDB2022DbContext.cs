using Microsoft.EntityFrameworkCore;

namespace ComuniDev.WebEFCore.API.Models
{
    public class SalesDB2022DbContext: DbContext
    {
        public SalesDB2022DbContext()
        {

        }
        public SalesDB2022DbContext(DbContextOptions<SalesDB2022DbContext> options): base(options)
        {

        }

    
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }


    }
}
