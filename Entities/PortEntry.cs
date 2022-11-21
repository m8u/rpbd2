namespace rpbd2.Entities
{
    public class PortEntry
    {
        public virtual int Id { get; protected set; }
        public virtual Port Port { get; set; }
        public virtual Cruise Cruise { get; set; }
        public virtual DateTime DestinationPlanned { get; set; }
        public virtual DateTime? DestinationActual { get; set; }
        public virtual DateTime DeparturePlanned { get; set; }
        public virtual DateTime? DepartureActual { get; set; }
        public virtual string DestinationDelayReason { get; set; }
        public virtual string DepartureDelayReason { get; set; }
    }
}
