using Microsoft.AspNetCore.Mvc;
using System;
using Escola;

namespace Escola.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AlunoController : ControllerBase
{
    private readonly AlunosRepository _repository = new AlunosRepository();

    [HttpGet]
    public IActionResult ListarAlunos([FromQuery] string nome)
    {
        var alunos = _repository.ListarAlunos(nome);
        return Ok(alunos);
    }

    [HttpGet("{id}")]
    public IActionResult ObterAluno(int id)
    {
        var aluno = _repository.ObterAluno(id);
        if (aluno == null)
        {
            return NotFound();
        }
        return Ok(aluno);
    }

    [HttpPost]
    public IActionResult CriarAluno([FromBody] CriacaoAlunoDto dto)
    {
        var aluno = new AlunoModel
        {
            Nome = dto.Nome,
            DataDeNascimento = dto.DataDeNascimento
        };

        _repository.AdicionarAluno(aluno);
        return CreatedAtAction(nameof(ObterAluno), new { id = aluno.Id }, aluno);
    }

    [HttpDelete("{id}")]
    public IActionResult ExcluirAluno(int id)
    {
        var aluno = _repository.ObterAluno(id);
        if (aluno == null)
        {
            return NotFound();
        }

        _repository.RemoverAluno(id);
        return NoContent();
    }
}
