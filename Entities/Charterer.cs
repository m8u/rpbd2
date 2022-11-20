namespace rpbd2.Entities
{
    public class Charterer
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Fax { get; set; }
        public virtual string Email { get; set; }
        public virtual string BankName { get; set; }
        public virtual string BankCity { get; set; }
        public virtual string BankTIN { get; set; }
        public virtual string BankAccountNumber { get; set; }
        public virtual IList<Cruise> Cruises { get; protected set; }
    }
}
