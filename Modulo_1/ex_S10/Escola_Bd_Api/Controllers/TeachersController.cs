using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Escola_Bd_Api.Models;
using Escola_Bd_Api.Services;

[ApiController]
[Route("api/[controller]")]
public class TeachersController : ControllerBase
{
    private readonly ITeacherService _teacherService;

    public TeachersController(ITeacherService teacherService)
    {
        _teacherService = teacherService;
    }

    [HttpGet]
    public async Task<IEnumerable<Teacher>> GetAllTeachers()
    {
        return await _teacherService.GetAllTeachers();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Teacher>> GetTeacherById(int id)
    {
        var teacher = await _teacherService.GetTeacherById(id);

        if (teacher == null)
        {
            return NotFound();
        }

        return teacher;
    }

    [HttpPost]
    public async Task<ActionResult<Teacher>> AddTeacher(Teacher teacher)
    {
        var createdTeacher = await _teacherService.AddTeacher(teacher);
        return CreatedAtAction(nameof(GetTeacherById), new { id = createdTeacher.Id }, createdTeacher);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateTeacher(int id, Teacher teacher)
    {
        if (id != teacher.Id)
        {
            return BadRequest();
        }

        await _teacherService.UpdateTeacher(teacher);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteTeacher(int id)
    {
        var result = await _teacherService.DeleteTeacher(id);

        if (!result)
        {
            return NotFound();
        }

        return NoContent();
    }
}
