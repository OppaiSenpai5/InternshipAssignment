using System.ComponentModel.DataAnnotations;

namespace ServiceLayer.DTOs
{
    public record TaskDto
    {
        [StringLength(100)]
        public required string Title { get; init; }
        [StringLength(500)]
        public required string Description { get; init; }
        [DataType(DataType.Date)]
        public required DateOnly DueDate { get; init; }
        [Range(1, int.MaxValue)]
        public required int AssigneeId { get; init; }
    }
}
