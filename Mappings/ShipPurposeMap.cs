using FluentNHibernate.Mapping;

namespace rpbd2.Mappings
{
    public class ShipPurposeMap : ClassMap<Entities.ShipPurpose>
    {
        public ShipPurposeMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }
}
