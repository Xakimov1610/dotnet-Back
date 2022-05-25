using Microsoft.AspNetCore.Mvc;
using StudentAPI.Services;

namespace StudentAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentContorller : ControllerBase
{
    private readonly ILogger<StudentServices> _logger;
    private readonly StudentServices _student;

    public StudentContorller(ILogger<StudentServices> logger, StudentServices student)
    {
        _logger = logger;
        _student = student;

    }

    [HttpGet, Route("/Students/GetAll")]
    public IActionResult GetStudents()
    {
        try
        {
            return Ok(_student.GetAllStudents());
        }
        catch(Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }

    [HttpGet, Route("/Student/id")]
    public IActionResult GetById(int id)
    {
        try
        {
            return Ok(_student.GetStudentById(id));
        }
        catch(Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }

    [HttpGet, Route("/Student/age")]
    public IActionResult GetByAge(int age)
    {
        try
        {
            return Ok(_student.GetStudentByAge(age));
        }
        catch(Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }

    [HttpPost, Route("/Student/Add")]
    public IActionResult Post([FromForm]Student std)
    {
        try
        {
            return Ok(_student.Add(std));
        }
        catch(Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }
}