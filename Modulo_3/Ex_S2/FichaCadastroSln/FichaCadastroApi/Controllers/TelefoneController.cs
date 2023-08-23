using AutoMapper;
using FichaCadastroApi.DTO.Ficha;
using FichaCadastroApi.DTO.Telefone;
using FichaCadastroApi.Model;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Linq;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;


namespace FichaCadastroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelefoneController : ControllerBase
    {
        private readonly FichaCadastroDbContext _context;
        private readonly IMapper _mapper;

        public TelefoneController(FichaCadastroDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Telefone
        [HttpGet]
        public ActionResult<IEnumerable<TelefoneReadDTO>> GetAllTelefones()
        {
            var telefones = _context.TelefoneModels.ToList();
            return Ok(_mapper.Map<IEnumerable<TelefoneReadDTO>>(telefones));
        }

        // GET: api/Telefone/{id}
        [HttpGet("{id}")]
        public ActionResult<TelefoneReadDTO> GetTelefoneById(int id)
        {
            var telefone = _context.TelefoneModels.Find(id);
            if (telefone == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<TelefoneReadDTO>(telefone));
        }

        // POST: api/Telefone
        [HttpPost]
        public ActionResult<TelefoneReadDTO> CreateTelefone(TelefoneCreateDTO telefoneCreateDto)
        {
            var telefone = _mapper.Map<TelefoneModel>(telefoneCreateDto);
            _context.TelefoneModels.Add(telefone);
            _context.SaveChanges();

            return Ok(_mapper.Map<TelefoneReadDTO>(telefone));
        }

        // PUT: api/Telefone/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateTelefone(int id, TelefoneUpdateDTO telefoneUpdateDto)
        {
            var telefone = _context.TelefoneModels.Find(id);
            if (telefone == null)
            {
                return NotFound();
            }

            _mapper.Map(telefoneUpdateDto, telefone);

            _context.TelefoneModels.Update(telefone);
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/Telefone/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteTelefone(int id)
        {
            var telefone = _context.TelefoneModels.Find(id);
            if (telefone == null)
            {
                return NotFound();
            }

            _context.TelefoneModels.Remove(telefone);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
