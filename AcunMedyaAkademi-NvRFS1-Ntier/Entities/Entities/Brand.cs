using Core.Entities;

namespace Entities
{
    public class Brand : BaseEntitiy<Guid>
    {
        public string Name { get; set; }
        public virtual ICollection<Model>? Models { get; set; } // Bir marka birden fazla modele sahip olabilir

        // Constructorlar burada olacak
        public Brand()
        {
        }

        public Brand(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
