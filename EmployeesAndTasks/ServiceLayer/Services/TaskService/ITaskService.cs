using ServiceLayer.DTOs;
using ServiceLayer.Services.BaseService;

namespace ServiceLayer.Services.TaskService
{
    public interface ITaskService : IBaseService<TaskDto, DomainEntities.Task>
    {
    }
}
