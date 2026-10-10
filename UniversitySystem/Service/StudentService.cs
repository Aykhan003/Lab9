using UniversitySystem.Data;
using UniversitySystem.Methods;
using Microsoft.EntityFrameworkCore;
namespace UniversitySystem.Service;

public class StudentService
{
    private readonly UniversityDbContext _context;
    
    public StudentService(UniversityDbContext context)
    {
        _context = context;
    }
    public async Task CreateStudentAsync(Student student)
    {
        await _context.Students.AddAsync(student);
        await _context.SaveChangesAsync();
    }
    public async Task<List<Student>> GetAllStudentsAsync()
    {
        return await _context.Students.ToListAsync();
    }
    public async Task UpdateStudentDepartmentAsync(int studentId, int newDepartmentId)
    {
        var student = await _context.Students.FindAsync(studentId);
        if (student != null)
        {
            student.DepartmentId = newDepartmentId;
            await _context.SaveChangesAsync();
        }
    }
    public async Task DeleteStudentAsync(int studentId)
    {
        var student = await _context.Students.FindAsync(studentId);
        if (student != null)
        {
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
        }
    }
    public async Task<List<Student>> GetStudentsByDepartmentAsync(int departmentId)
    {
        return await _context.Students
            .Where(s => s.DepartmentId == departmentId)
            .ToListAsync();
    }
}
