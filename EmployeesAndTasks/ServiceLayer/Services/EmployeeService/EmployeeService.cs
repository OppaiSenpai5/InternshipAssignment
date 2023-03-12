using AutoMapper;
using DataAccess.Repositories.EmployeeRepository;
using DomainEntities;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.DTOs;
using ServiceLayer.Services.BaseService;

namespace ServiceLayer.Services.EmployeeService
{
    public class EmployeeService :
        BaseService<IEmployeeRepository, EmployeeDto, Employee>,
        IEmployeeService
    {
        public EmployeeService(IEmployeeRepository repo, IMapper mapper)
            : base(repo, mapper)
        {
        }

        public IEnumerable<EmployeeDto> Top5Employees()
        {
            var employees = Repo.GetAll().Include(x => x.Tasks);
            var top5employees = employees.ToDictionary(x => Mapper.Map<EmployeeDto>(x),
                x => x.Tasks
                        .Where(y => y.DueDate.Month == DateTime.Now.Month - 1)
                        .Count());

            return top5employees
                .OrderByDescending(x => x.Value)
                .Select(x => x.Key)
                .Take(5);
        }
    }
}
