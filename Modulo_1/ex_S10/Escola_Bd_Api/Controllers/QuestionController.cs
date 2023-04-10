using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Escola_Bd_Api.Models;
using Escola_Bd_Api.Services;

[Route("api/[controller]")]
[ApiController]
public class QuestionController : ControllerBase
{
    private readonly IQuestionService _service;

    public QuestionController(IQuestionService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Question>>> GetQuestions()
    {
        return Ok(await _service.GetAllQuestions());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Question>> GetQuestion(int id)
    {
        var question = await _service.GetQuestionById(id);

        if (question == null)
        {
            return NotFound();
        }

        return Ok(question);
    }

    [HttpPost]
    public async Task<ActionResult<Question>> PostQuestion(Question question)
    {
        var createdQuestion = await _service.AddQuestion(question);
        return CreatedAtAction("GetQuestion", new { id = createdQuestion.Id }, createdQuestion);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutQuestion(int id, Question question)
    {
        if (id != question.Id)
        {
            return BadRequest();
        }

        try
        {
            await _service.UpdateQuestion(question);
        }
        catch (Exception)
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteQuestion(int id)
    {
        var success = await _service.DeleteQuestion(id);

        if (!success)
        {
            return NotFound();
        }

        return NoContent();
    }
}
