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
        }
    }
}
