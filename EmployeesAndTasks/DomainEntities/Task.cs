using System.ComponentModel.DataAnnotations.Schema;

namespace DomainEntities
{
    public record Task : BaseEntity
    {
        public required string Title { get; init; }
        public required string Description { get; init; }
        public required DateOnly DueDate { get; init; }

        // MANY TO ONE
        [ForeignKey("Assignee")]
        public required int AssigneeId { get; init; }
        public Employee? Assignee { get; init; }
    }
}
