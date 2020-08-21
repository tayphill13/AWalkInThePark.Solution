using System.ComponentModel.DataAnnotations;

namespace Parks.Models
{
  public class StatePark
  {
    public int StateParkId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string County { get; set; }
    [Required]
    public bool CampingAccess { get; set; }
  }
}