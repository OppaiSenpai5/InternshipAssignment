using System.ComponentModel.DataAnnotations;

namespace DomainEntities
{
    public abstract record BaseEntity
    {
        [Key]
        public required int Id { get; init; }
    }
}
