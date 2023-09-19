using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.CompanyDto;

    public class GetCompanyDto
    {
      public int Id { get; set; }
     public string Name { get; set; }
        public List<GetCompanyEmployeeDto> Employees { get; set; } = new(); 
    
    }

