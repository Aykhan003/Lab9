using Lab9.Data;
using Lab9.Methods;
using Lab9.Service;
using var context = new SchoolDbContext();

//var studentService = new StudentService(context);

//var newStudent = new Student
//{
//    FirstName = "Rasul",
//    LastName = "Rasulov",
//    Age = 23,
//    Email = "rasul.rasulov@gmail.com"
//};
//var newStudent2 = new Student
//{
//    FirstName = "Mehseti",
//    LastName = "Aliyeva",
//    Age = 19,
//    Email = "mehseti.aliyeva@gmail.com"
//};
//var newStudent3 = new Student
//{
//    FirstName = "Ramin",
//    LastName = "Huseynov",
//    Age = 21,
//    Email = "ramin.huseynov@gmail.com"
//};
//var newStudent4 = new Student
//{
//    FirstName = "Aysel",
//    LastName = "Huseynova",
//    Age = 20,
//    Email = "aysel.huseynova@gmail.com"
//};
//var newStudent5 = new Student
//{
//    FirstName = "Nigar",
//    LastName = "Huseynova",
//    Age = 22,
//    Email = "nigar.huseynova@gmail.com"
//};
//await studentService.CreateStudentAsync(newStudent);
//Console.WriteLine("Student created successfully.");
//await studentService.CreateStudentAsync(newStudent2);
//Console.WriteLine("Student created successfully.");
//await studentService.CreateStudentAsync(newStudent3);
//Console.WriteLine("Student created successfully.");
//await studentService.CreateStudentAsync(newStudent4);
//Console.WriteLine("Student created successfully.");
//await studentService.CreateStudentAsync(newStudent5);
//Console.WriteLine("Student created successfully.");
var studentService = new StudentService(context);
var students = await studentService.GetAllStudentsAsync();
foreach (var student in students)
{

    Console.WriteLine($"Student: {student.FirstName} {student.LastName}, Age: {student.Age}, Email: {student.Email}");
}

