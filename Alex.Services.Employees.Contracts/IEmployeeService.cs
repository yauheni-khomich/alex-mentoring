using System;
using System.Threading.Tasks;
using Alex.Services.Employees.Contracts.Models;

namespace Alex.Services.Employees.Contracts
{
    public interface IEmployeeService
    {
        object Add { get; }

        Task<Employee> GetByIdAsync(Guid id);
    }
}
