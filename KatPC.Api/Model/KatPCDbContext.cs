using Microsoft.EntityFrameworkCore;

namespace KatPC.Api.Model
{
    public class KatPCDbContext : DbContext
    {
        public KatPCDbContext(DbContextOptions<KatPCDbContext> options) : base(options)
        {

        }

        public DbSet<KatPCDatos> KatPCs { get; set; }
    }
}
