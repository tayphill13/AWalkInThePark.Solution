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
      builder.Entity<NationalPark>()
      .HasData(
        new NationalPark { NationalParkId = 1, Name = "Crater_Lake_National_Park", State = "Oregon", AccessPrice = 30},
        new NationalPark { NationalParkId = 2, Name = "Oregon_Caves_National_Park", State = "Oregon", AccessPrice = 10},
        new NationalPark { NationalParkId = 3, Name = "Fort_Vancouver_National_Park", State = "Washington", AccessPrice = 10},
        new NationalPark { NationalParkId = 4, Name = "San_Juan_National_Park", State = "Washington", AccessPrice = 0},
        new NationalPark { NationalParkId = 5, Name = "Point_Reyes_National_Park", State = "California", AccessPrice = 0},
        new NationalPark { NationalParkId = 6, Name = "Golden_Gate_National_Park", State = "California", AccessPrice = 0}
      );
      builder.Entity<StatePark>()
      .HasData(
        new StatePark { StateParkId = 1, Name = "Bandon_State_Natural_Area", State = "Oregon", County = "Coos"},
        new StatePark { StateParkId = 2, Name = "Cascadia_State_Park", State = "Oregon", County = "" },
        new StatePark { StateParkId = 3, Name = "", State = "Washington", County = "" },
        new StatePark { StateParkId = 4, Name = "", State = "Washington", County = "" },
        new StatePark { StateParkId = 5, Name = "", State = "California", County = "" },
        new StatePark { StateParkId = 6, Name = "", State = "California", County = "" }
      );
    }
  }
}
