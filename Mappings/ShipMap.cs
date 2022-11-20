using FluentNHibernate.Mapping;

namespace rpbd2.Mappings
{
    public class ShipMap : ClassMap<Entities.Ship>
    {
        public ShipMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.CarryCapacity);
            References(x => x.Homeport);
            References(x => x.Purpose);
            HasMany(x => x.Crew);
            Map(x => x.Location);
            Map(x => x.OverhaulStartDate);
            References(x => x.CurrentCruise);
        }
    }
}
