namespace rpbd2.Entities
{
    public class Cruise
    {
        public virtual int Id { get; protected set; }
        public virtual Ship Ship { get; set; }
        public virtual GeneralCargoType GeneralCargoType { get; set; }
        public virtual Port DeparturePort { get; set; }
        public virtual Port DestinationPort { get; set; }
        public virtual IList<PortEntry> PortEntries { get; protected set; }
        public virtual Charterer Charterer { get; set; }
           
        public Cruise()
        {
            PortEntries = new List<PortEntry>();
        }
    }
}
