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
      builder.Entity<>()
      .HasData(
        new NationalPark { NationalParkId = 1, Name = "Crater_Lake", Location = "Oregon", AccessPrice = 30},
        new NationalPark { NationalParkId = 2, Name = "Oregon_Caves", Location = "Oregon", AccessPrice = 10},
        
      )
    }
  }
}