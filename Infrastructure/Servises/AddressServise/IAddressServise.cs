using Domain.DTOs.CompanyDto;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DTOs.AddresDto;

namespace Infrastructure.Servises.AddressServise
{
    public interface IAddressServise
    {
        Task<string> Add(AddAddressEmployeeDto add);
        Task<List<EmployeeAddress>> Get();
        Task<string> Updata(AddAddressEmployeeDto add);
        Task<EmployeeAddress> GetById(int id);
        Task<bool> Delete(int id);

    }
}
