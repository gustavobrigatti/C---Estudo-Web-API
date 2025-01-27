using AutoMapper;
using Estudo_1___Web_API.Domain.DTOs;
using Estudo_1___Web_API.Domain.Models;

namespace Estudo_1___Web_API.Application.Mapping
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping() 
        {
            CreateMap<Employee, EmployeeDTO>()
                .ForMember(dest => dest.NameEmployee, m => m.MapFrom(orig => orig.name));
        }
    }
}
