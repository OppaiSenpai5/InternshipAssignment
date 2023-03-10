using DomainEntities;
using System.Linq.Expressions;

namespace DataAccess.Repositories.BaseRepository
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        IQueryable<T> GetAll();
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> condition);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}
