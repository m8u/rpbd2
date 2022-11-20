using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpbd2.Entities
{
    public class Ship
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual float CarryCapacity { get; set; }
        public virtual Port Homeport { get; set; }
        public virtual ShipPurpose Purpose { get; set; }
        public virtual IList<CrewMember> Crew { get; protected set; }
        public virtual int[] Location { get; set; }
        public virtual DateOnly OverhaulStartDate { get; set; }

        // public Cruise getCurrentCruise()
    }
}
