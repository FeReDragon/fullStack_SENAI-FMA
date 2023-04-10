using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Escola_Bd_Api.Models;
using Escola_Bd_Api.Services;

[Route("api/[controller]")]
[ApiController]
public class QuizController : ControllerBase
{
    private readonly IQuizService _service;

    public QuizController(IQuizService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Quiz>>> GetQuizzes()
    {
        return Ok(await _service.GetAllQuizzes());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Quiz>> GetQuiz(int id)
    {
        var quiz = await _service.GetQuizById(id);

        if (quiz == null)
        {
            return NotFound();
        }

        return Ok(quiz);
    }

    [HttpPost]
    public async Task<ActionResult<Quiz>> PostQuiz(Quiz quiz)
    {
        var createdQuiz = await _service.AddQuiz(quiz);
        return CreatedAtAction("GetQuiz", new { id = createdQuiz.Id }, createdQuiz);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutQuiz(int id, Quiz quiz)
    {
        if (id != quiz.Id)
        {
            return BadRequest();
        }

        try
        {
            await _service.UpdateQuiz(quiz);
        }
        catch (Exception)
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteQuiz(int id)
    {
        var success = await _service.DeleteQuiz(id);

        if (!success)
        {
            return NotFound();
        }

        return NoContent();
    }
}
