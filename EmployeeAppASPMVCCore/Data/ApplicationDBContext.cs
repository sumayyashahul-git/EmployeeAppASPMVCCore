using EmployeeAppASPMVCCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAppASPMVCCore.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
          : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; } = default!;
    }
}
