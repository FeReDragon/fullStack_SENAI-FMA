using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Escola_Bd_Api.Models;
using Microsoft.AspNetCore.Http;
using FluentValidation;

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly IStudentService _service;
    private readonly StudentValidator _validator;

    public StudentsController(IStudentService service)
    {
        _service = service;
        _validator = new StudentValidator();
    }

    // GET: api/Students
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
    {
        return Ok(await _service.GetAllStudents());
    }

    // GET: api/Students/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Student>> GetStudent(int id)
    {
        var student = await _service.GetStudentById(id);

        if (student == null)
        {
            return NotFound();
        }

        return student;
    }

    // PUT: api/Students/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutStudent(int id, Student student)
    {
        if (id != student.Id)
        {
            return BadRequest();
        }

        var validationResult = _validator.Validate(student);
        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors);
        }

        await _service.UpdateStudent(student);

        return NoContent();
    }

    // POST: api/Students
    [HttpPost]
    public async Task<ActionResult<Student>> PostStudent(Student student)
    {
        var validationResult = _validator.Validate(student);
        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors);
        }

        await _service.AddStudent(student);

        return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, student);
    }

    // DELETE: api/Students/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStudent(int id)
    {
        var result = await _service.DeleteStudent(id);
        if (!result)
        {
            return NotFound();
        }

        return NoContent();
    }
}
