using DomainEntities;

namespace ServiceLayer.Services.BaseService
{
    public interface IBaseService<TDto, TEntity>
        where TEntity : BaseEntity
    {
        TDto Get(int id);
        IEnumerable<TDto> GetAll();
        void Create(TDto dto);
        void Update(int id, TDto dto);
        void Delete(int id);
    }
}
