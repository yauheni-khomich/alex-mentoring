using System;
using System.Linq;
using System.Threading.Tasks;
using Alex.Services.Employees.Contracts.Models;
using Alex.Services.Employees.Data.Mappers;
using Alex.Services.Employees.Data.Models;
using Alex.Services.Employees.Domain.Data;
using AutoMapper;

namespace Alex.Services.Employees.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IMapper mapper;
        private readonly ApplicationDbContext dbContext;

        public EmployeeRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            this.mapper = EmployeeMapperFactory.Create();
        }

        public Task CreateAsync(Employee employee)
        {
            // TODO: Implenment string in DB.
            throw new NotImplementedException();
        }

        public Task<Employee> GetByIdAsync(Guid id)
        {
            var employeeData = dbContext.Employes.AsQueryable().SingleOrDefault(x => x.Id == id);
            var employee = mapper.Map<Employee>(employeeData);

            return Task.FromResult(employee);
        }
    }
}
