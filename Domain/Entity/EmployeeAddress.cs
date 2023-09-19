using System.ComponentModel.DataAnnotations;
namespace Domain;
public class EmployeeAddress
{
    public string Address { get; set; }
    [Key]
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
}
