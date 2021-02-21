using Alex.Services.Employees.Contracts.Models;
using Alex.Services.Employees.Data.Models;
using AutoMapper;

namespace Alex.Services.Employees.Data.Mappers.MapperProfiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            this.CreateMap<Employee, EmployeeData>()
                .ReverseMap();

            this.CreateMap<Address, AddressData>()
                .ForMember(x => x.City, opt => opt.MapFrom(c => c.City))
                .ReverseMap()
                .ForMember(x => x.City, opt => opt.MapFrom(c => c.City));
        }
    }
}
