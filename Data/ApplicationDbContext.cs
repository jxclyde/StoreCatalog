using Microsoft.EntityFrameworkCore;
using StoreCatalog.Models;

namespace StoreCatalog.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Processor> processors { get; set; }
        public DbSet<Motherboard> motherboards { get; set;}
        public DbSet<GraphicsCard> graphicscards { get; set; }

    }
}
