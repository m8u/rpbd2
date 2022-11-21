namespace rpbd2.Entities
{
    public class Port
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }

        public override string? ToString()
        {
            return this.Name;
        }
    }
}
