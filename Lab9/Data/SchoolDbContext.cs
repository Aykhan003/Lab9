using Lab9.Methods;
using Microsoft.EntityFrameworkCore;

namespace Lab9.Data;

public class SchoolDbContext:DbContext
{
    override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Server=localhost;Database=SQLLab;Trusted_Connection=true;TrustServerCertificate=true;");
    }
    public DbSet<Student> Students { get; set; }
}
