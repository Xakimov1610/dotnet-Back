namespace StudentAPI.Services;

public class StudentServices
{
    private readonly ILogger<StudentServices> _logger;

    public List<Student> Students {get; set; } = new () 
        {new Student() { Id = 1, Name = "Ali", LastName = "Valiyev", Age = 23}, new Student() { Id = 1, Name = "Xoshim", LastName = "Toshiyev", Age = 44}};
    public StudentServices(ILogger<StudentServices> logger)
    {
        _logger = logger;
    }

    public List<Student> GetAllStudents() => Students;

    
}
