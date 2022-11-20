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
        public virtual DateTime OverhaulStartDate { get; set; }
        public virtual Cruise CurrentCruise { get; set; }

        public Ship()
        {
            Crew = new List<CrewMember>();
        }

        public virtual void AddCrewMember(CrewMember member)
        {
            member.CurrentShip = this;
            Crew.Add(member);
        }

        public virtual void RemoveCrewMember(CrewMember member)
        {
            member.CurrentShip = null;
            Crew.Remove(member); 
        }
    }
}
