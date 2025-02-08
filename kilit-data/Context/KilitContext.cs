using kilit_data.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace kilit_data.Context
{
    public class KilitContext:DbContext
    {
        public KilitContext(DbContextOptions<KilitContext> options) : base(options)
        { 
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Kilit");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> User { get; set; }

    }
}
