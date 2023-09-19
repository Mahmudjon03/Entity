using Domain;
using Domain.DTOs.EmployeeSkill;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Servises.SkillEmployeeServise
{
    public class EmployeeSkilServise : ISkillEmployeeServise
    {
       
        private readonly DataContext _dataContext;

        public EmployeeSkilServise(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<string> AddSkillEmployee(AddEmployeeSkill addEmployeeSkill)
        {
            var es=new EmployeeSkill();
            es.SkillId = addEmployeeSkill.SkillId;
            es.EmployeeId = addEmployeeSkill.EmploeId;
          await  _dataContext.EmployeeSkills.AddAsync(es);
            _dataContext.SaveChanges();
            return "true";
        }

        public async Task<List<EmployeeSkill>> Get()
        {
       return await  _dataContext.EmployeeSkills.ToListAsync();
        }
    }
}
