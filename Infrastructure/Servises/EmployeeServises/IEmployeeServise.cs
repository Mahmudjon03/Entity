

using Domain;
using Domain.DTOs.Employees;
using Domain.DTOs.EmployeesDto;

namespace Infrastructure.Servises.EmployeeServises
{
    public interface IEmployeeServise
    {
        Task<string> AddEmployee(AddEmployeeDto add);
        Task<string> Update(UpdateEmployeeDto add);
        Task<bool> Delete(int id);
        Task<Employee> GEtById(int id);
        Task<List<Employee>> Get();
    }
}
