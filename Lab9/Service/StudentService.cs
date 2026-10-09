using Lab9.Data;
using Lab9.Methods;
using Microsoft.EntityFrameworkCore;
namespace Lab9.Service;

public class StudentService
{
    private readonly SchoolDbContext _context;
    public StudentService(SchoolDbContext context)
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
    public async Task UpdateStudentAgeAsync(int studentId, int newAge)
    {
        var student = await _context.Students.FindAsync(studentId);
        if (student != null)
        {
            student.Age = newAge;
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
    public async Task<List<Student>> GetStudentsOlder18Async()
    {
        return await _context.Students
            .Where(s => s.Age > 18)
            .ToListAsync();
    }
    public async Task<List<Student>> GetStudentsOrderByNameAsync()
    {
        return await _context.Students
            .OrderBy(s => s.FirstName)
            .ToListAsync();
    }
    public async Task<List<Student>> GetTop3OldestStudentsAsync()
    {
        return await _context.Students
            .OrderByDescending(s => s.Age)
            .Take(3)
            .ToListAsync();
    }
    public async Task<Student?> GetStudentByNameAsync(string firstName)
    {
        return await _context.Students
            .FirstOrDefaultAsync(s => s.FirstName == firstName);
    }
    public async Task<int> GetStudentCountAsync()
    {
        return await _context.Students.CountAsync();
    }
    public async Task<List<Student>> GetStudentsByAgeRangeAsync()
    {
        return await _context.Students
            .Where(s => s.Age >= 20 && s.Age <= 25)
            .ToListAsync();
    }
    public async Task<List<Student>> GetStudentsByEmailDomainAsync(string domain)
    {
        return await _context.Students
            .Where(s => s.Email.EndsWith(domain))
            .ToListAsync();
    }
}
