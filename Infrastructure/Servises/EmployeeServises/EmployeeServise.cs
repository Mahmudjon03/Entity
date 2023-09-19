using Domain;
using Domain.DTOs.Employees;
using Domain.DTOs.EmployeesDto;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Servises.EmployeeServises
{
    public class EmployeeServise : IEmployeeServise
    {
        private readonly DataContext _dataContext;

        public EmployeeServise(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<string> AddEmployee(AddEmployeeDto add )
        {
            try
            {
                var emp = new Employee();
                emp.FullName = add.FullName;
                emp.CompanyId= add.CompanyId;
              await  _dataContext.Employees.AddAsync(emp);
                _dataContext.SaveChanges();
                return "Added employee";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                _dataContext.Employees.Remove(await _dataContext.Employees.FindAsync(id));
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<List<Employee>> Get()
        {
            return await _dataContext.Employees.ToListAsync();
        }

        public async Task<Employee> GEtById(int id)
        {
            return await _dataContext.Employees.FindAsync(id);
        }

        public async Task<string> Update(UpdateEmployeeDto add)
        {
          var emp= await _dataContext.Employees.FindAsync(add.Id);
            emp.FullName= add.FullName;
            _dataContext.SaveChanges();
            return "Employee Update";

        }
    }
}
