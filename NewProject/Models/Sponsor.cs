using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SponsorMatch.Models
{
  public class Sponsor
  {
    public int SponsorId { get; set; }
    [Required(ErrorMessage = "Please enter a name for the sponsor.")]
    public string SponsorName {get; set;}
    [Required(ErrorMessage = "Please enter a type for the sponsor.")]
    public string SponsorType {get; set;}
    public List<AthleteSponsor> JoinEntities { get; set; }  
  }
}