using System.ComponentModel.DataAnnotations;

namespace ServiceLayer.DTOs
{
    public record EmployeeDto
    {
        [StringLength(50)]
        public required string FullName { get; init; }
        [EmailAddress]
        public required string Email { get; init; }
        [Phone]
        public required string PhoneNumber { get; init; }
        [DataType(DataType.Date)]
        public required DateOnly DateOfBirth { get; init; }
        [DataType(DataType.Currency)]
        public required decimal MonthlySalary { get; init; }
    }
}
