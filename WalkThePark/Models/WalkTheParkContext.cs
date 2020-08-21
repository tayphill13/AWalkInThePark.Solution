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
        new NationalPark { NationalParkId = 6, Name = "Golden_Gate_National_Park", State = "California", AccessPrice = 0},
        new NationalPark { NationalParkId = 7, Name = "John_Day_Fossil_Beds", State = "Oregon", AccessPrice = 0 },
        new NationalPark { NationalParkId = 8, Name = "Oregon_Dunes_National_Recreation_Area", State = "Oregon", AccessPrice = 0},
        new NationalPark { NationalParkId = 9, Name = "Mount_Rainier_National_Park", State = "Washington", AccessPrice = 15 },
        new NationalPark { NationalParkId = 10, Name = "Yosemite_National_Park", State = "California", AccessPrice = 15 }
      );
      builder.Entity<StatePark>()
      .HasData(
        new StatePark { StateParkId = 1, Name = "Bandon_State_Natural_Area", State = "Oregon", County = "Coos"},
        new StatePark { StateParkId = 2, Name = "Cascadia_State_Park", State = "Oregon", County = "Linn" },
        new StatePark { StateParkId = 3, Name = "Fort_Ebey_State_Park", State = "Washington", County = "Island" },
        new StatePark { StateParkId = 4, Name = "Ginkgo_Petrified_Forest", State = "Washington", County = "Kittitas" },
        new StatePark { StateParkId = 5, Name = "Emerald_Bay_State_Park", State = "California", County = "El_Dorado" },
        new StatePark { StateParkId = 6, Name = "Grizzly_Creek_Redwoods", State = "California", County = "Humboldt" },
        new StatePark { StateParkId = 7, Name = "Champoeg_State_Heritage_Area", State = "Oregon", County = "Marion"},
        new StatePark { StateParkId = 8, Name = "Milo_McIver_State_Park", State = "Oregon", County = "Clackamas" },
        new StatePark { StateParkId = 9, Name = "Beacon_Rock_State_Park", State = "Washington", County = "Skamania" },
        new StatePark { StateParkId = 10, Name = "Castle_Rock_State_Park", State = "California", County = "Santa_Cruz" }
      );
    }
    public DbSet<NationalPark> NationalParks { get; set; }
    public DbSet<StatePark> StateParks  { get; set; }
  }
}
