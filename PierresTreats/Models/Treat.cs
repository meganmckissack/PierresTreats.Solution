using System.Collections.Generic;

namespace PierresTreats.Models
{
    public class Treat
    {
        public Treat()
        {
            this.JoinTreatFlavor = new HashSet<TreatFlavor>();
        }

        public int TreatId { get; set; }
        public string TreatName { get; set; }
        public virtual ICollection<TreatFlavor> JoinTreatFlavor { get; set; }
        
    }
}