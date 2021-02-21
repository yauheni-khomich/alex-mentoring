using System;
using System.Threading.Tasks;
using Alex.Services.Employees.Contracts;
using Alex.Services.Employees.Contracts.Models;
using Alex.WebApi.Employees.Models;
using Microsoft.AspNetCore.Mvc;

namespace Alex.WebApi.Employees.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService ?? throw new ArgumentNullException(nameof(employeeService));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById([FromRoute] Guid id)
        {
            var employee = await employeeService.GetByIdAsync(id);
            // 
            // TODO: here we should return EmployeeDto model instead of Employee model (which is Business layer model)
            // it should be taken from one more mapper
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] CreateEmployeeRequestDto dto)
        {
            // TODO: convert dtoModel to Employee model by using Mapping
            var employeeId = await employeeService.CreateAsync(
                new CreateEmployeeRequest
                {
                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    BirthDate = dto.BirthDate,
                    Salary = dto.Salary,
                    Address = new Address
                    {
                        City = dto.Address.City,
                        CountryCode = dto.Address.CountryCode,
                    },
                });

            return Ok();
        }
    }
}
