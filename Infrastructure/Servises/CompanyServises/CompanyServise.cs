using Domain;
using Domain.DTOs.CompanyDto;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Servises.CompanyServises;

    public class CompanyServise : ICompanyServise
    {
        private readonly DataContext _dataContext;

        public CompanyServise(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<string> AddCompany(AddCompanyDto add)
        {
            try
            {
                var com = new Company();
                com.Name = add.Name;
                await _dataContext.Companies.AddAsync(com);
                _dataContext.SaveChanges();
                return "added Company";
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
            _dataContext.Companies.Remove(await _dataContext.Companies.FindAsync(id));
            _dataContext.SaveChanges();
            return true;
        }

        catch (Exception ex)
        {

            return false;
        }
    }

        public async Task<List<GetCompanyDto>> GetAllCompanes()
    {
            return await _dataContext.Companies.Select(company=>new GetCompanyDto
            {
                Id = company.Id,
                Name = company.Name,
                Employees= _dataContext.Employees.Where(x=>x.CompanyId==company.Id).Select(employee=>new GetCompanyEmployeeDto
                {
                    Id=employee.Id,
                    name=employee.FullName

                }).ToList(),
            }).ToListAsync();
        }

        public async Task<Company> GetCompanyById(int id)
        {
            return await _dataContext.Companies.FindAsync(id);
        }
        public async Task<string> Updata(UpdataCompanyDto add)
        {
            try
            {
                var res = await _dataContext.Companies.FindAsync(add.Id);
                if (res == null) { return "404"; }
                res.Name = add.Name;
                _dataContext.SaveChanges();
                return "company update ";
            }
            catch (Exception x ) 
            {

                 return x.Message; 
            }
        }
    }

