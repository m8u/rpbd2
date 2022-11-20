using FluentNHibernate.Mapping;

namespace rpbd2.Mappings
{
    public class PortMap : ClassMap<Entities.Port>
    {
        public PortMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }
}
