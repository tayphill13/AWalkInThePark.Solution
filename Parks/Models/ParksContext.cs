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
        new Park { ParkId = 1, }
      )
    }
  }
}