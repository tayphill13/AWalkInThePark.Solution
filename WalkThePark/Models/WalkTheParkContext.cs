using Microsoft.EntityFrameworkCore;

namespace WalkThePark.Models
{

  public class WalkTheParkContext : DbContext
  {

    public WalkTheParkContext(DbContextOptions<WalkTheParkContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
      .HasData(
        new Park { ParkId = 1, Name = "Crater_Lake", State = "Oregon", ParkType = "National", AccessPrice = 30},
        new Park { ParkId = 2, Name = "Oregon_Caves", State = "Oregon", ParkType = "National", AccessPrice = 10},
        new Park { ParkId = 3, Name = "Fort_Vancouver", State = "Washington", ParkType = "National", AccessPrice = 10},
        new Park { ParkId = 4, Name = "San_Juan", State = "Washington", ParkType = "National", AccessPrice = 0},
        new Park { ParkId = 5, Name = "Point_Reyes", State = "California", ParkType = "National", AccessPrice = 0},
        new Park { ParkId = 6, Name = "Golden_Gate", State = "California", ParkType = "National", AccessPrice = 0}
      );
    }
  }
}
