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
            Map(x => x.Homeport);
            Map(x => x.Purpose);
            HasMany(x => x.Crew);
            Map(x => x.Location);
            Map(x => x.OverhaulStartDate);
            Map(x => x.CurrentCruise);
        }
    }
}
