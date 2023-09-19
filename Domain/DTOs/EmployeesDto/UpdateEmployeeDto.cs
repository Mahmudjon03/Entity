using Domain.DTOs.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.EmployeesDto
{
    public class UpdateEmployeeDto:BaseEmployeeDto
    {
        public int Id { get; set; }
    }
}
