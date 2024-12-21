using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace ClassLibrary1
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Regions> Regions { get; set; }
    }
}

public class Regions
{
    [Key]
    public int RegionID { get; set; }
    public string RegionDescription { get; set; }
}
