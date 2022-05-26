namespace StudentAPI.Services;

public class StudentServices
{
    private readonly ILogger<StudentServices> _logger;

    public List<Student> Students {get; set; } = new () 
        {new Student() { Id = 1, Name = "Ali", LastName = "Valiyev", Age = 23}, new Student() { Id = 2, Name = "Xoshim", LastName = "Toshiyev", Age = 44}};
    public StudentServices(ILogger<StudentServices> logger)
    {
        _logger = logger;
    }

    public List<Student> GetAllStudents() => Students;

    public Student GetStudentById(int id) => Students.FirstOrDefault(x => x.Id == id);
   
    public Student GetStudentByAge(int age) => Students.FirstOrDefault(x => x.Age == age);

    public Student Add(Student std)
    {
        Students.Add(std);
        return Students.FirstOrDefault(x => x.Id == std.Id);
    }

    public Student Update(Student std)
    {
        var student = Students.FirstOrDefault(x => x.Id == std.Id);
        if(student != null)
        {
            student.Name = std.Name;
            student.LastName = std.LastName;
            student.Age = std.Age;
        }
        return student;
    }
    public Student Delete(int id)
    {
        var student = Students.FirstOrDefault(x => x.Id == id);
        if(student != null)
        {
            Students.Remove(student);
        }
        return student;
    }
    public bool Exists (int id) => Students.Any(x => x.Id == id);
}
