using Microsoft.EntityFrameworkCore;

namespace sample_crud_backend.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext( DbContextOptions<EmployeeContext> opions) : base(opions)
        {
           
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
