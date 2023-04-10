using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Escola_Bd_Api.Models;

[ApiController]
[Route("api/[controller]")]
public class StudentDisciplineController : ControllerBase
{
    private readonly IStudentDisciplineService _studentDisciplineService;

    public StudentDisciplineController(IStudentDisciplineService studentDisciplineService)
    {
        _studentDisciplineService = studentDisciplineService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<StudentDiscipline>>> GetStudentDisciplines()
    {
        return Ok(await _studentDisciplineService.GetAllStudentDisciplines());
    }

    [HttpGet("{studentId}/{disciplineId}")]
    public async Task<ActionResult<StudentDiscipline>> GetStudentDiscipline(int studentId, int disciplineId)
    {
        var studentDiscipline = await _studentDisciplineService.GetStudentDisciplineById(studentId, disciplineId);

        if (studentDiscipline == null)
        {
            return NotFound();
        }

        return Ok(studentDiscipline);
    }

    [HttpPost]
    public async Task<ActionResult<StudentDiscipline>> CreateStudentDiscipline(StudentDiscipline studentDiscipline)
    {
        await _studentDisciplineService.AddStudentDiscipline(studentDiscipline);
        return CreatedAtAction(nameof(GetStudentDiscipline), new { studentId = studentDiscipline.StudentId, disciplineId = studentDiscipline.DisciplineId }, studentDiscipline);
    }

    [HttpPut("{studentId}/{disciplineId}")]
    public async Task<IActionResult> UpdateStudentDiscipline(int studentId, int disciplineId, StudentDiscipline studentDiscipline)
    {
        if (studentId != studentDiscipline.StudentId || disciplineId != studentDiscipline.DisciplineId)
        {
            return BadRequest();
        }

        await _studentDisciplineService.UpdateStudentDiscipline(studentDiscipline);
        return NoContent();
    }

    [HttpDelete("{studentId}/{disciplineId}")]
    public async Task<IActionResult> DeleteStudentDiscipline(int studentId, int disciplineId)
    {
        var result = await _studentDisciplineService.DeleteStudentDiscipline(studentId, disciplineId);

        if (!result)
        {
            return NotFound();
        }

        return NoContent();
    }
}
