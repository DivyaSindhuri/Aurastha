using Aurastha.Api.Business.Interfaces;
using Aurastha.Api.Models.Domain;
using Aurastha.Api.Models.DTO.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aurastha.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService) 
        {
            _employeeService = employeeService;
        }

        [HttpPost]
        public async Task<ActionResult<List<Employee>>> AddEmployee(CreateEmployeeDTO employee)
        {
            var result = await _employeeService.AddEmployee(employee);

            return StatusCode((int)result.Code, result.Value);
        }
    }
}
