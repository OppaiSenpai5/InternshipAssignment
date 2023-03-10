using DomainEntities;
using ServiceLayer.DTOs;
using ServiceLayer.Services.BaseService;

namespace ServiceLayer.Services.EmployeeService
{
    public interface IEmployeeService : IBaseService<EmployeeDto, Employee>
    {
    }
}
