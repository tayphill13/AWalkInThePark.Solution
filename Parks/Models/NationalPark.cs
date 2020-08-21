using System.ComponentModel.DataAnnotations;

namespace Parks.Models
{
  public class NationalPark
  {
    public int NationalParkId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Location { get; set; }
    [Required]
    public int AccessPrice { get; set; }
  }
}