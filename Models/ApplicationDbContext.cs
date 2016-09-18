using Microsoft.Data.Entity;
namespace WebApplication6.Models
{
    public class ApplicationDbContext : DbContext
    {

        //base.OnModelCreating(builder);
        public DbSet<Player> Players { get; set; }
        public DbSet<Season> Seasons { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Conventions.Remove<PluralizingTableNameConvention>();
           
    // builder.Entity<Player>().HasOne(typeof(Season)).WithMany().HasForeignKey("SeasonId").OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Cascade);
            base.OnModelCreating(builder);

            // builder.Entity<Player>().HasOne(typeof(Season)).WithMany().HasForeignKey

        }
    }
}
