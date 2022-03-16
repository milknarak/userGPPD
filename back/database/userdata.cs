using Microsoft.EntityFrameworkCore;
namespace program
{
    public class context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@"Host=172.16.0.49;Username=postgres;Password=p@ssw0rd;Database=milk_practice");
        public DbSet<userdata> userdata { get; set; }
    }
    [Keyless]
    public class userdata
    {
        public string id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
    }
}
