using FluentNHibernate.Mapping;

namespace rpbd2.Mappings
{
	public class ChartererMap : ClassMap<Entities.Charterer>
	{
		public ChartererMap()
		{
			Id(x => x.Id);
			Map(x => x.Name);
			Map(x => x.Address);
			Map(x => x.PhoneNumber);
			Map(x => x.Fax);
			Map(x => x.Email);
			Map(x => x.BankName);
			Map(x => x.BankCity);
			Map(x => x.BankTIN);
			Map(x => x.BankAccountNumber);
			HasMany(x => x.Cruises)
				.Cascade.All();
		}
	}
}
