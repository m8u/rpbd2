using FluentNHibernate.Mapping;

namespace rpbd2.Mappings
{
    public class CruiseMap : ClassMap<Entities.Cruise>
    {
        public CruiseMap()
        {
            Id(x => x.Id);
            References(x => x.Ship);
            References(x => x.GeneralCargoType);
            References(x => x.DeparturePort);
            References(x => x.DestinationPort);
            HasMany(x => x.PortEntries)
                .Cascade.All();
            References(x => x.Charterer);
        }
    }
}
