using Domain;
using Domain.DTOs.CompanyDto;
using Infrastructure.Servises.CompanyServises;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController
    {
        private readonly ICompanyServise _companyServise;

        public CompanyController(ICompanyServise companyServise)
        {
            _companyServise = companyServise;
        }
        [HttpPost("AddCompany")]
         public async Task<string> AddCompany(AddCompanyDto addCompanyDto) => await _companyServise.AddCompany(addCompanyDto);
        [HttpGet("GetCompany")]
        public async Task<List<GetCompanyDto>> GEt() => await _companyServise.GetAllCompanes();
        [HttpGet("getById")]
        public async Task<Company> GetById(int id ) => await _companyServise.GetCompanyById(id);
        [HttpPut("Udate Company")]
        public async Task<string> Udate(UpdataCompanyDto addCompanyDto)=> await _companyServise.Updata(addCompanyDto);
        [HttpDelete("Delete Company")]
        public async Task<bool> Delete(int id)=> await _companyServise.Delete(id);
        
    }
}
