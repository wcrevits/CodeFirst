using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Domain.Context
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions options) : base(options)
        {
        }
        DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
            new Employee()
            {
                EmployeeId = 1,
                Name = "Johan",
                Designation =
            "Developer",
                Address = "Kortrijk",
                CompanyName = "XYZ Inc",
                Salary = 30000
            },
            new Employee()
            {
                EmployeeId = 2,
                Name = "Chris",
                Designation =
            "Manager",
                Address = "Gent",
                CompanyName = "ABC Inc",
                Salary = 50000
            },
            new Employee()
            {
                EmployeeId = 3,
                Name = "Karel",
                Designation =
            "Consultant",
                Address = "Brugge",
                CompanyName = "XYZ Inc",
                Salary = 20000
            });
        }
    }
}
