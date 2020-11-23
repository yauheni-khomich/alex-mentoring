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

            // TODO: here we should return EmployeeDto model instead of Employee model (which is Business layer model)
            return Ok(employee);
        }
    }
}
