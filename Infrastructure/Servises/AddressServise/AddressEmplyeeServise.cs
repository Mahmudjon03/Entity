using Domain;
using Domain.DTOs.AddresDto;
using Domain.DTOs.CompanyDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Servises.AddressServise
{
    public class AddressEmplyeeServise:IAddressServise
    {
        private readonly DataContext _dataContext;

        public AddressEmplyeeServise(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<string> Add(AddAddressEmployeeDto add)
        {
            var a = new EmployeeAddress();
            a.Address = add.Addres;
            a.EmployeeId = add.EmployeeId;
            await _dataContext.EmployeeAddresses.AddAsync(a);
            _dataContext.SaveChanges();
            return "address added";
            
        }

        public async Task<bool> Delete(int id)
        {
            _dataContext.EmployeeAddresses.Remove(await _dataContext.EmployeeAddresses.FindAsync(id));
            return true;    

        }

        public async Task<List<EmployeeAddress>> Get()
        {
            return await _dataContext.EmployeeAddresses.ToListAsync();
        }

        public async Task<EmployeeAddress> GetById(int id)
        {
            return await _dataContext.EmployeeAddresses.FindAsync(id);
        }

        public async Task<string> Updata(AddAddressEmployeeDto add)
        {
            var res =await _dataContext.EmployeeAddresses.FindAsync(add.EmployeeId);
            res.Address= add.Addres;
            _dataContext.SaveChanges();
            return "Address Update";

        }
    }
}
