using System;
using System.Threading.Tasks;
using Alex.Services.Employees.Contracts.Models;

namespace Alex.Services.Employees.Contracts
{
    public interface IEmployeeService
    {
        Task<Employee> GetByIdAsync(Guid id);

        Task<Guid> CreateAsync(CreateEmployeeRequest createRequest);
    }
}
