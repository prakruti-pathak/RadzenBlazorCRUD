using Microsoft.EntityFrameworkCore;

namespace RadzenBlazor.Domains
{
    public class CarDbContext:DbContext
    {
        public CarDbContext(DbContextOptions<CarDbContext> options):base(options)
        {
            
        }
        public DbSet<CarEntity> Cars { get; set; }
    }
}
