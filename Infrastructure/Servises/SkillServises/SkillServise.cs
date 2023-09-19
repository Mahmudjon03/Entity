using Domain;
using Domain.DTOs.SkillDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Servises.SkillServises
{
    public class SkillServise:ISkillServise
    {
        private readonly DataContext _dataContext;

        public SkillServise(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<string> Add(AddSkillDto add)
        {
            var skil = new Skill();
            skil.SkillName = add.Name;
          await  _dataContext.Skills.AddAsync(skil);
            _dataContext.SaveChanges();
            return "skill added";
        }

        public async Task<bool> Delete(int id)
        {
            _dataContext.Skills.Remove (await _dataContext.Skills.FindAsync(id));
            return true;
        }

        public async Task<List<Skill>> Get()
        {
            return await _dataContext.Skills.ToListAsync();
        }

        public async Task<Skill> GEtById(int id)
        {
            return await _dataContext.Skills.FindAsync (id);
        }

        public async Task<string> Update(UpdateSkillDto add)
        {
            var res =  _dataContext.Skills.Find(add.Id);
            res.SkillName = add.Name;
          await  _dataContext.SaveChangesAsync();
            return "skill update";
            }
    }
}
