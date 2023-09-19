using Domain;
using Domain.DTOs.Employees;
using Domain.DTOs.EmployeesDto;
using Infrastructure.Servises.EmployeeServises;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace WebApi.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class EmployeeController:ControllerBase
    {
        private readonly IEmployeeServise _employeeServise;

        public EmployeeController(IEmployeeServise employeeServise)
        {
            _employeeServise = employeeServise;
        }
         [HttpPost("AddEmployee")]
        public async Task<string> AddEmployee(AddEmployeeDto add) => await _employeeServise.AddEmployee(add);
        [HttpDelete("Delete Emplyee")]
        public async Task<bool> Delete(int id) => await _employeeServise.Delete(id);
        [HttpGet("GetbyId")]
        public async Task<Employee> GetById(int id) => await _employeeServise.GEtById(id);
        [HttpGet("GetEmployee")]
        public async Task<List<Employee>> Get()=> await  _employeeServise.Get();
  
        [HttpPut("Update")]
        public async Task<string> Update(UpdateEmployeeDto employeeDto) =>await _employeeServise.Update(employeeDto);
 }
