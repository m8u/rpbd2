using FluentNHibernate.Mapping;


namespace rpbd2.Mappings
{
    public class CrewMemberMap : ClassMap<Entities.CrewMember>
    {
        public CrewMemberMap ()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Patronymic);
            Map(x => x.BirthDate);
            References(x => x.Role);
            Map(x => x.Experience);
            Map(x => x.Salary);
            References(x => x.CurrentShip);
        }
    }
}
