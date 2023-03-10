using AutoMapper;
using DataAccess.Repositories.EmployeeRepository;
using DomainEntities;
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
    }
}
