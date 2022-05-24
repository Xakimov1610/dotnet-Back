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

    [HttpGet, Route("get")]
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
}