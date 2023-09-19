using Domain;
using Domain.DTOs.EmployeeSkill;

namespace Infrastructure.Servises.SkillEmployeeServise
{
    public interface ISkillEmployeeServise
    {
        Task<string> AddSkillEmployee(AddEmployeeSkill addEmployeeSkill);
        Task<List<EmployeeSkill>>  Get();


    }
}
