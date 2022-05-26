using Microsoft.AspNetCore.Mvc;
using StudentApi.Entities;
using StudentApi.Models;
using StudentApi.Services;

namespace StudentApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly ILogger<StudentController> _logger;
    private readonly StudentService _studentService;

    public StudentController(ILogger<StudentController> logger, StudentService studentService)
    {
        _logger = logger;
        _studentService = studentService;
    }

    [HttpGet("/getstudent/{id}")]
    public IActionResult GetById(Guid id)
    {
        if(!_studentService.Exists(id)) return BadRequest($"Doesn't exist student with {id} id");

        return Ok(_studentService.Get(id));
    }

    [HttpGet("/students")]
    public IActionResult GetAll()
    {
        try
        {
            return Ok(_studentService.GetAll());
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }

    [HttpPost("/addstudent")]
    public IActionResult AddStudent([FromForm]NewStudent newStudent)
    {
        try
        {
            _studentService.AddStudent(newStudent);
            return Ok("Student is added");
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest("Student isn't added");
        }
    }

    [HttpPut("/updatestudent")]
    public IActionResult UpdateStudent([FromForm]Student st)
    {
        if(!_studentService.Exists(st.Id)) return BadRequest($"Doesn't exist student with {st.Id} id");

        _studentService.Update(st);
        return Ok("Student is updated");
    }

    [HttpDelete("/deletestudent")]
    public IActionResult DeleteStudent(Guid id)
    {
        if(!_studentService.Exists(id)) return BadRequest($"Doesn't exist student with {id} id");

        _studentService.DeleteStudent(id);
        return Ok("Student is deleted");
    }
}