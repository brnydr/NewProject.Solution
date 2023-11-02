using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SponsorMatch.Models
{
  public class Athlete
  {
    public int AthleteId { get; set; }
    [Required(ErrorMessage = "Please enter a name for the athlete.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Please enter a sport for the athlete.")]
    public string Sport { get; set; }
    public List<AthleteSponsor> JoinEntities { get; set; }
  }
}