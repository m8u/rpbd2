using FluentNHibernate.Mapping;

namespace rpbd2.Mappings
{
    public class RoleMap : ClassMap<Entities.Role>
    {
        public RoleMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }
}
