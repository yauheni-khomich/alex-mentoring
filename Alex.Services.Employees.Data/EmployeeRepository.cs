using System;
using System.Threading.Tasks;
using Alex.Services.Employees.Contracts.Models;
using Alex.Services.Employees.Data.Mappers;
using Alex.Services.Employees.Data.Models;
using Alex.Services.Employees.Domain.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Alex.Services.Employees.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IMapper mapper;

        public EmployeeRepository()
        {
            this.mapper = EmployeeMapperFactory.Create();
        }

        public Task<Employee> GetByIdAsync(Guid id)
        {
            // TODO: fetch from DB.
            var employeeData = new EmployeeData { FirstName = "alex", LastName = "Lipski" };

            var employee = mapper.Map<Employee>(employeeData);

            return Task.FromResult(employee);
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
    .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test")
    .Options;

            using var context = new ApplicationDbContext(contextOptions);
        }
    }
}
