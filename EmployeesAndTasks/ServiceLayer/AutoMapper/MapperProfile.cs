using AutoMapper;
using DomainEntities;
using ServiceLayer.DTOs;

namespace ServiceLayer.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<EmployeeDto, Employee>().ReverseMap();
            CreateMap<TaskDto, DomainEntities.Task>().ReverseMap();
        }
    }
}
