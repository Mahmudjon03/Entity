using Domain;
using Domain.DTOs.EmployeeSkill;
using Infrastructure.Servises.SkillEmployeeServise;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
    public class EmployeeSkillController
    {
    private readonly ISkillEmployeeServise _skill;

    public EmployeeSkillController(ISkillEmployeeServise skill)
    {
        _skill = skill;
    }
    [HttpGet("GetEmployeeSkill")]
    public async Task<List<EmployeeSkill>> GetAll() => await _skill.Get();
    [HttpPost("AddEmployeeSkill")]
    public async Task<string> Add(AddEmployeeSkill skil)=> await _skill.AddSkillEmployee(skil);
}

