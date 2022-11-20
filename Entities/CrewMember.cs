namespace rpbd2.Entities
{
    public class CrewMember
    {
        public virtual int Id { get; protected set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Patronymic { get; set; }
        public virtual DateOnly BirthDate { get; set; }
        public virtual Role Role { get; set; }
        public virtual int Experience { get; set; }
        public virtual int Salary { get; set; }
        public virtual Ship? CurrentShip { get; set; }
    }
}
