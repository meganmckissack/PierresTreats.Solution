using System.Collections.Generic;
using System;

namespace PierresTreats.Models 
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinTreatFlavor = new HashSet<TreatFlavor>();
    }
    public int FlavorId { get; set; }
    public string FlavorName { get; set; }
    public virtual ApplicationUser User { get; set; } 
    public virtual ICollection<TreatFlavor> JoinTreatFlavor { get; set; }
    
  }
}