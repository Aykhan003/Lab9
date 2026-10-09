using Microsoft.EntityFrameworkCore;
using UniversitySystem.Methods;

namespace UniversitySystem.Data;

public class    UniversityDbContext: DbContext
{
    override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Server=localhost;Database=UniversitySystem;Trusted_Connection=true;TrustServerCertificate=true;");
    }
    public DbSet<Student> Students { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Course> Courses { get; set; }
}
