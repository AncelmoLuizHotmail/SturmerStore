namespace SturmerStore.Domain.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            DataInclusao = DateTime.Now;
        }

        public int Id { get; protected set; }
        public DateTime DataInclusao { get; private set; }
        public DateTime? DataAlteracao { get; protected set; }
        public DateTime? DataExclusao { get; protected set; }
    }
}
