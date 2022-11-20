using FluentNHibernate.Mapping;

namespace rpbd2.Mappings
{
    public class GeneralCargoTypeMap : ClassMap<Entities.GeneralCargoType>
    {
        public GeneralCargoTypeMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }
}
