using Domain;
using Domain.DTOs.SkillDto;
using Infrastructure.Servises.SkillServises;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace WebApi.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class SkillController
    {
        private readonly ISkillServise _skillServise;

        public SkillController(ISkillServise skillServise)
        {
            _skillServise = skillServise;
        }
        [HttpGet("GetSkill")]
        public async Task<List<Skill>> Get()=>await  _skillServise.Get();
        [HttpPost("AddSkill")]
        public async Task<string> Add(AddSkillDto skil)=> await _skillServise.Add(skil);
        [HttpPut("UpdateSkiill")]
        public async Task<string> Update(UpdateSkillDto updateSkillDto)=> await _skillServise.Update(updateSkillDto);
        [HttpGet("GetByIdSkill")]
        public async Task<Skill> GEtById(int id)=> await    _skillServise.GEtById(id);
        [HttpDelete("Delete")]
        public async Task<bool>  Delte(int id)=>   await _skillServise.Delete(id); 

}
