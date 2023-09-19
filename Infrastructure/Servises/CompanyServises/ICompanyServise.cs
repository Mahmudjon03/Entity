using Domain;
using Domain.DTOs.CompanyDto;
namespace Infrastructure.Servises.CompanyServises
{
    public interface ICompanyServise
    {
     Task<string> AddCompany(AddCompanyDto add);
        Task<List<GetCompanyDto>> GetAllCompanes();
        Task<string> Updata(UpdataCompanyDto add);
        Task<Company> GetCompanyById(int id);
        Task<bool> Delete(int id);
        
    }

}
