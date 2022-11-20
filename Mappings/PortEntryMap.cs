using FluentNHibernate.Mapping;

namespace rpbd2.Mappings
{
    public class PortEntryMap : ClassMap<Entities.PortEntry>
    {
        public PortEntryMap()
        {
            Id(x => x.Id);
            Map(x => x.Port);
            Map(x => x.Cruise);
            Map(x => x.DestinationPlanned);
            Map(x => x.DestinationActual);
            Map(x => x.DeparturePlanned);
            Map(x => x.DepartureActual);
            Map(x => x.DestinationDelayReason);
            Map(x => x.DepartureDelayReason);
        }
    }
}
