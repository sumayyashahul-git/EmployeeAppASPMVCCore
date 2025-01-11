using System.ComponentModel.DataAnnotations;

namespace EmployeeAppASPMVCCore.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }

        [Required]
        [MaxLength(100)]
        public string DepartmentName { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
