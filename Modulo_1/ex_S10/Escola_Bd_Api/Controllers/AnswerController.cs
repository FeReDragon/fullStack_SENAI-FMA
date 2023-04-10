using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Escola_Bd_Api.Models;
using Escola_Bd_Api.Services;

[Route("api/[controller]")]
[ApiController]
public class AnswerController : ControllerBase
{
    private readonly IAnswerService _service;

    public AnswerController(IAnswerService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Answer>>> GetAnswers()
    {
        return Ok(await _service.GetAllAnswers());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Answer>> GetAnswer(int id)
    {
        var answer = await _service.GetAnswerById(id);

        if (answer == null)
        {
            return NotFound();
        }

        return Ok(answer);
    }

    [HttpPost]
    public async Task<ActionResult<Answer>> PostAnswer(Answer answer)
    {
        var createdAnswer = await _service.AddAnswer(answer);
        return CreatedAtAction("GetAnswer", new { id = createdAnswer.Id }, createdAnswer);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAnswer(int id, Answer answer)
    {
        if (id != answer.Id)
        {
            return BadRequest();
        }

        try
        {
            await _service.UpdateAnswer(answer);
        }
        catch (Exception)
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAnswer(int id)
    {
        var success = await _service.DeleteAnswer(id);

        if (!success)
        {
            return NotFound();
        }

        return NoContent();
    }
}
