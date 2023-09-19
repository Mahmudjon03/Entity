using System.ComponentModel.DataAnnotations;
namespace Domain;
public class Employee
{
   
    public int Id { get; set; }
    [MaxLength(40)]
    public string FullName { get; set; }
    public int CompanyId { get; set; }
    public Company Company { get; set; } = null!;
    public EmployeeAddress Employeeaddres { get; set; }
    public ICollection<EmployeeSkill> EmployeeSkill { get; set; }
}
