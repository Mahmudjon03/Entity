using Domain.DTOs.Employees;
using Domain.DTOs.EmployeesDto;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DTOs.SkillDto;

namespace Infrastructure.Servises.SkillServises
{
    public interface ISkillServise
    {
        Task<string> Add(AddSkillDto add);
        Task<string> Update(UpdateSkillDto add);
        Task<bool> Delete(int id);
        Task<Skill> GEtById(int id);
        Task<List<Skill>> Get();
    }
}
