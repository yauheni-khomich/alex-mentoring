using System;
using System.Threading.Tasks;
using Alex.Services.Employees.Contracts;
using Alex.Services.Employees.Contracts.Models;
using Alex.Services.Employees.Domain.Data;

namespace Alex.Services.Employees.Domain
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
        }

        public async Task<Employee> GetByIdAsync(Guid id)
        {
            var employee = await employeeRepository.GetByIdAsync(id);

            return employee;
        }
    }
}
