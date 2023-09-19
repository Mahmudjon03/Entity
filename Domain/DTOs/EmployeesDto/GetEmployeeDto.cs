using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.Employees
{
     public class GetEmployeeDto
    {
        public string FullName { get; set; }
        public EmployeeAddress MyProperty { get; set; }
        //public List<EmployeeSkill> employeeSkills { get; set; }
    }
}
