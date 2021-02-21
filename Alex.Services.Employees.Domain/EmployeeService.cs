using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alex.Services.Employees.Contracts;
using Alex.Services.Employees.Contracts.Models;
using Alex.Services.Employees.Domain.Data;

namespace Alex.Services.Employees.Domain
{
    public class EmployeeService : IEmployeeService
    {
        private static readonly ICollection<string> SupprtedCountryCodes = new[] { "BY", "US" };

        private readonly IEmployeeRepository employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
        }

        public async Task<Guid> CreateAsync(CreateEmployeeRequest createRequest)
        {
            // IMPORTANT!!! always check parameters of public method not to be nulls.
            if (createRequest == null)
            {
                throw new ArgumentNullException(nameof(createRequest));
            }

            // Business layer can also validate some data.
            if (!SupprtedCountryCodes.Contains(createRequest.Address.CountryCode))
            {
                throw new Exception($"Creating employees for country({createRequest.Address.CountryCode}) is not supported." +
                    $"Supported countries are {string.Join(',', SupprtedCountryCodes)}");
            }

            var employeeToCreate = new Employee
            {
                FirstName = createRequest.FirstName,
                LastName = createRequest.LastName,
                BirthDate = createRequest.BirthDate,
                Salary = createRequest.Salary,
                Address = new Address
                {
                    City = createRequest.Address.City,
                    CountryCode = createRequest.Address.CountryCode,
                },
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow
            };

            await employeeRepository.CreateAsync(employeeToCreate);

            return employeeToCreate.Id;
        }

        public async Task<Employee> GetByIdAsync(Guid id)
        {
            var employee = await employeeRepository.GetByIdAsync(id);

            return employee;
        }
    }
}
