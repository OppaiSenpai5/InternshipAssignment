using Microsoft.AspNetCore
    .Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs;
using ServiceLayer.Services.EmployeeService;

namespace Web.Controllers
{
    [Route("api/v1/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet("{id:int}")]
        public IActionResult Get([FromRoute] int id)
        {
            var employee = this.employeeService.Get(id);
            return employee is null ? NotFound() : Ok(employee);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this.employeeService.GetAll());
        }

        [HttpPost]
        public IActionResult Post([FromForm] EmployeeDto employee)
        {
            this.employeeService.Create(employee);
            return CreatedAtAction(nameof(Get), employee);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put([FromRoute] int id, [FromForm] EmployeeDto employee)
        {
            this.employeeService.Update(id, employee);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            this.employeeService.Delete(id);
            return NoContent();
        }

        [HttpGet("top5")]
        public IActionResult Top5Employees()
        {
            return Ok(this.employeeService.Top5Employees());
        }
    }
}
