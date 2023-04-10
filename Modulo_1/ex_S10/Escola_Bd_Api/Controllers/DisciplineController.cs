using Escola_Bd_Api.Models;
using Escola_Bd_Api.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escola_Bd_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplineController : ControllerBase
    {
        private readonly IDisciplineService _disciplineService;

        public DisciplineController(IDisciplineService disciplineService)
        {
            _disciplineService = disciplineService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Discipline>>> GetDisciplines()
        {
            var disciplines = await _disciplineService.GetDisciplines();
            return Ok(disciplines);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Discipline>> GetDisciplineById(int id)
        {
            var discipline = await _disciplineService.GetDisciplineById(id);
            if (discipline == null)
            {
                return NotFound();
            }
            return Ok(discipline);
        }

        [HttpPost]
        public async Task<ActionResult<Discipline>> CreateDiscipline(Discipline discipline)
        {
            try
            {
                var createdDiscipline = await _disciplineService.CreateDiscipline(discipline);
                return CreatedAtAction(nameof(GetDisciplineById), new { id = createdDiscipline.Id }, createdDiscipline);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Discipline>> UpdateDiscipline(int id, Discipline discipline)
        {
            try
            {
                var updatedDiscipline = await _disciplineService.UpdateDiscipline(id, discipline);
                return Ok(updatedDiscipline);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiscipline(int id)
        {
            try
            {
                await _disciplineService.DeleteDiscipline(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
