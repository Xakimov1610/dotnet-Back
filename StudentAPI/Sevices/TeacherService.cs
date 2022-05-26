using StudentApi.Entities;
using StudentApi.Models;

namespace StudentApi.Services;
public class TeacherService
{
    private readonly ILogger<TeacherService> _logger;
    public List<Teacher> Teachers { get; set; } = new() {new(){Id = Guid.NewGuid(), FirstName = "Gates", LastName = "Bill", Subject = "Math"}};

    public TeacherService(ILogger<TeacherService> logger)
    {
        _logger = logger;
    }
    public List<Teacher> GetAll() => Teachers;

    public Teacher Get(Guid id) => Teachers.FirstOrDefault(s => s.Id == id);
    public void AddTeacher(NewTeacher newTeacher)
    {
        var teacher = new Teacher() {
            Id = Guid.NewGuid(),
            FirstName = newTeacher.FirstName,
            LastName = newTeacher.LastName,
            Subject = newTeacher.Subject
        };
        Teachers.Add(teacher);
    }

    public void DeleteTeacher(Guid id)
    {
        var Teacher = Teachers.FirstOrDefault(s => s.Id == id);
        Teachers.Remove(Teacher);
    }

    public void Update(Teacher Teacher)
    {
        var oldTeacher = Teachers.FirstOrDefault(s => s.Id == Teacher.Id);
        oldTeacher.Subject = Teacher.Subject;
        oldTeacher.FirstName = Teacher.FirstName;
        oldTeacher.LastName = Teacher.LastName;
    }

    public bool Exists(Guid id) => Teachers.Any(s => s.Id == id);
}