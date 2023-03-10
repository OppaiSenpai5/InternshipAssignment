using AutoMapper;
using DataAccess.Repositories.TaskRepository;
using ServiceLayer.DTOs;
using ServiceLayer.Services.BaseService;

namespace ServiceLayer.Services.TaskService
{
    public class TaskService :
        BaseService<ITaskRepository, TaskDto, DomainEntities.Task>,
        ITaskService
    {
        public TaskService(ITaskRepository repo, IMapper mapper) 
            : base(repo, mapper)
        {
        }
    }
}
