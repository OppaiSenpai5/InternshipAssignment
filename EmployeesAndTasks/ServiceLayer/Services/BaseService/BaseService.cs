using AutoMapper;
using DataAccess.Repositories.BaseRepository;
using DomainEntities;

namespace ServiceLayer.Services.BaseService
{
    public class BaseService<TRepo, TDto, TEntity> : IBaseService<TDto, TEntity>
        where TRepo : IBaseRepository<TEntity>
        where TEntity : BaseEntity
    {
        protected readonly TRepo Repo;
        private readonly IMapper Mapper;

        public BaseService(TRepo repo, IMapper mapper)
        {
            Repo = repo;
            Mapper = mapper;
        }

        public TDto Get(int id)
        {
            return Mapper.Map<TDto>(Repo.GetById(id));
        }

        public IEnumerable<TDto> GetAll()
        {
            return Repo.GetAll().Select(x => Mapper.Map<TDto>(x));
        }

        public void Create(TDto dto)
        {
            Repo.Create(Mapper.Map<TEntity>(dto));
            Repo.Save();
        }

        public void Update(int id, TDto dto)
        {
            var entity = Repo.GetById(id);
            Repo.Update(Mapper.Map(dto, entity));
            Repo.Save();
        }

        public void Delete(int id)
        {
            Repo.Delete(Repo.GetById(id));
            Repo.Save();
        }
    }
}
