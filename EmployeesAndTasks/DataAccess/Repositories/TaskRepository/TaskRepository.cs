using DataAccess.Repositories.BaseRepository;

namespace DataAccess.Repositories.TaskRepository
{
    public class TaskRepository : BaseRepository<DomainEntities.Task>, ITaskRepository
    {
        public TaskRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
