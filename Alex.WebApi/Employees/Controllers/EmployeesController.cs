using System;
using System.Threading.Tasks;
using Alex.Services.Employees.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Alex.WebApi.Employees.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
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
            var employeeDto = employeeService.GetByIdAsync<EmployeeDto>().Select(o => new Employee()
            {
                Name = o.Name,
                Surname = o.Surname,
                BirthDate = o.BirthDate
            });
            // TODO: here we should return EmployeeDto model instead of Employee model (which is Business layer model)
            return employeeDto;
        }

        //[HttpGet]
        //public void AddEmployee([FromQuery] Employ)
        //{
        //    employeeService.S

        //}
    }
}
