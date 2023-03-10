using DataAccess.Repositories.BaseRepository;
using DomainEntities;

namespace DataAccess.Repositories.EmployeeRepository
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
