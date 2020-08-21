using Microsoft.EntityFrameworkCore;

namespace Parks.Models
{

  public class ParksContext : DbContext
  {

    public ParksContext(DbContextOptions<ParksContext>
    options)
    : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
      .HasData(
        new Park { ParkId = 1, Name = "Crater_Lake", State = "Oregon", AccessPrice = 30},
        new Park { ParkId = 2, Name = "Oregon_Caves", State = "Oregon", AccessPrice = 10},
        new Park { ParkId = 3, Name = "Fort_Vancouver", State = "Washington", AccessPrice = 10},
        new Park { ParkId = 4, Name = "San_Juan", State = "Washington", AccessPrice = 0},
        new Park { ParkId = 5, Name = "Point_Reyes", State = "California", AccessPrice = 0},
        new Park { ParkId = 6, Name = "Golden_Gate", State = "California", AccessPrice = 0}
      );
    }
  }
}
