using Lab9.Data;
using Lab9.Methods;

SchoolDbContext context = new SchoolDbContext();
Student student = new Student
{
    FirstName = "Ibrahim",
    LastName = "Ibrahimov",
    Age = 20,
    Email = "ibrahim.ibrahimov@gmail.com"
};
context.Students.Add(student);
context.SaveChanges();