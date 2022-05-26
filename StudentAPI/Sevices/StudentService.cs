using StudentApi.Entities;
using StudentApi.Models;

namespace StudentApi.Services;
public class StudentService
{
    private readonly ILogger<StudentService> _logger;
    public List<Student> Students { get; set; } = new() {new(){Id = Guid.NewGuid(), FirstName = "Shukhrat", LastName = "Utaboev", Age = 21, TeacherId = new("ff8adbc3-7022-4100-be0f-648c5d22d7d6")}};

    public StudentService(ILogger<StudentService> logger)
    {
        _logger = logger;
    }
    public List<Student> GetAll() => Students;

    public Student Get(Guid id) => Students.FirstOrDefault(s => s.Id == id);
    public void AddStudent(NewStudent newStudent)
    {
        var st = new Student() {
            Id = Guid.NewGuid(),
            FirstName = newStudent.FirstName,
            LastName = newStudent.LastName,
            Age = newStudent.Age,
            TeacherId = newStudent.TeacherId
        };
        Students.Add(st);
    }

    public void DeleteStudent(Guid id)
    {
        var student = Students.FirstOrDefault(s => s.Id == id);
        Students.Remove(student);
    }

    public void Update(Student student)
    {
        var oldStudent = Students.FirstOrDefault(s => s.Id == student.Id);
        oldStudent.Age = student.Age;
        oldStudent.FirstName = student.FirstName;
        oldStudent.LastName = student.LastName;
    }

    public bool Exists(Guid id) => Students.Any(s => s.Id == id);

    public List<Student> GetAllStudentByTeacherId(Guid id) => Students.Where(s => s.TeacherId == id).ToList();
}
