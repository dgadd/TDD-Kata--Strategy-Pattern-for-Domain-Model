namespace Gaddzeit.Kata.Domain
{
    public class DomainEntity
    {
        public int Id { get; set; }

        public override bool Equals(object obj)
        {
            var other = (DomainEntity) obj;
            return other.Id.Equals(this.Id);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
    }
}