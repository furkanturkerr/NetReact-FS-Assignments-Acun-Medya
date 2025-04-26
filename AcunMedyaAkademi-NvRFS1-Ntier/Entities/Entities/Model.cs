using Core.Entities;

namespace Entities
{
    public class Model: BaseEntitiy<Guid>
    {
        public string Name { get; set; }
        public Guid BrandId { get; set; }

        public  virtual Brand? Brand { get; set; }
        public virtual ICollection<Car> Cars { get; set; }

        public Model() {
            Cars = new HashSet<Car>();
        }

        public Model(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
