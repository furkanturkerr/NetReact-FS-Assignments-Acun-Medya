namespace Core.Entities
{
    public class BaseEntitiy<TId>
    {
        public TId Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UptadetDate { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
