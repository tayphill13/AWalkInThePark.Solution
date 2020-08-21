using System.ComponentModel.DataAnnotations;

namespace WalkThePark.Models
{
  public class NationalPark
  {
    public int NationalParkId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string State { get; set; }
    [Required]
    public int AccessPrice { get; set; }
  }
}