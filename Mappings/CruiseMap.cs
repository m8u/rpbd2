using FluentNHibernate.Mapping;

namespace rpbd2.Mappings
{
    public class CruiseMap : ClassMap<Entities.Cruise>
    {
        public CruiseMap()
        {
            Id(x => x.Id);
            Map(x => x.Ship);
            Map(x => x.GeneralCargoType);
            Map(x => x.DeparturePort);
            Map(x => x.DestinationPort);
            HasMany(x => x.PortEntries)
                .Cascade.All();
            Map(x => x.Charterer);
        }
    }
}
