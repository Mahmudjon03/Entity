using System.ComponentModel.DataAnnotations;
namespace Domain;
public class Skill
{
    public int Id { get; set; }
    [MaxLength(60)]
    public string SkillName { get; set; }
    public ICollection<EmployeeSkill> EmployeeSkills  { get; set; }
}
