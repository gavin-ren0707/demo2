using Microsoft.EntityFrameworkCore;

namespace demo2.Models {
    public class KSContext : DbContext {
        public KSContext (DbContextOptions<KSContext> options) : base (options) { }
        public DbSet<Info> ScenicSpots { get; set; }
    }
}