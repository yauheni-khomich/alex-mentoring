using System;
using System.Threading.Tasks;
using Alex.Services.Employees.Contracts.Models;

namespace Alex.Services.Employees.Domain.Data
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetByIdAsync(Guid id);
    }
}