using Microsoft.EntityFrameworkCore;

namespace KatPC.Api.Model
{
    public class KatPCDbContext : DbContext
    {
        public KatPCDbContext(DbContextOptions<KatPCDbContext> options) : base(options)
        {

        }

        public DbSet<especifiDATA> especifiDATA { get; set; }
    }
}
