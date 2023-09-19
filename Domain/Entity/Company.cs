using System.ComponentModel.DataAnnotations;

namespace Domain;
public class Company
{
    public int Id { get; set; }
    [MaxLength(40)]
    public string Name { get; set; }
    public List<Employee> Employee { get; set; } = new();
}
