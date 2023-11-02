using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SponsorMatch.Models
{
  public class SponsorMatchContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Sponsor> Sponsors { get; set; }
    public DbSet<Athlete> Athletes { get; set; }
    public DbSet<AthleteSponsor> AthleteSponsor { get; set; }
    public SponsorMatchContext(DbContextOptions options) : base(options) { }
  }
}