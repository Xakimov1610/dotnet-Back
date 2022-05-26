using Microsoft.AspNetCore.Mvc;
using StudentApi.Entities;
using StudentApi.Models;
using StudentApi.Services;

namespace StudentApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class TeacherController : ControllerBase
{
    private readonly ILogger<TeacherController> _logger;
    private readonly TeacherService _TeacherService;

    public TeacherController(ILogger<TeacherController> logger, TeacherService TeacherService)
    {
        _logger = logger;
        _TeacherService = TeacherService;
    }

    [HttpGet("/getTeacher/{id}")]
    public IActionResult GetById(Guid id)
    {
        if(!_TeacherService.Exists(id)) return BadRequest($"Doesn't exist Teacher with {id} id");

        return Ok(_TeacherService.Get(id));
    }

    [HttpGet("/Teachers")]
    public IActionResult GetAll()
    {
        try
        {
            return Ok(_TeacherService.GetAll());
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest(e.Message);
        }
    }

    [HttpPost("/addTeacher")]
    public IActionResult AddTeacher([FromForm]NewTeacher newTeacher)
    {
        try
        {
            _TeacherService.AddTeacher(newTeacher);
            return Ok("Teacher is added");
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest("Teacher isn't added");
        }
    }

    [HttpPut("/updateTeacher")]
    public IActionResult UpdateTeacher([FromForm]Teacher st)
    {
        if(!_TeacherService.Exists(st.Id)) return BadRequest($"Doesn't exist Teacher with {st.Id} id");

        _TeacherService.Update(st);
        return Ok("Teacher is updated");
    }

    [HttpDelete("/deleteTeacher")]
    public IActionResult DeleteTeacher(Guid id)
    {
        if(!_TeacherService.Exists(id)) return BadRequest($"Doesn't exist Teacher with {id} id");

        _TeacherService.DeleteTeacher(id);
        return Ok("Teacher is deleted");
    }
}