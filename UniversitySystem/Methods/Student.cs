namespace UniversitySystem.Methods;

public class Student
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
    public List<Course> Courses { get; set; }
}
