using Alex.Services.Employees.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Alex.Services.Employees.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<EmployeeData> Employes { get; set; }
    }
}