using Microsoft.EntityFrameworkCore;

namespace DomainEntities
{
    public record Employee : BaseEntity
    {
        public required string FullName { get; init; }
        public required string Email { get; init; }
        public required string PhoneNumber { get; init; }
        public required DateOnly DateOfBirth { get; init; }
        [Precision(18, 2)]
        public required decimal MonthlySalary { get; init; }

        // ONE TO MANY
        public IEnumerable<Task>? Tasks { get; init; }
    }
}
