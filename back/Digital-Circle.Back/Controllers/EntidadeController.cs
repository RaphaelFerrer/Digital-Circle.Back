using Digital_Circle.Back.Data;
using Digital_Circle.Back.Domain.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Digital_Circle.Back.Controllers
{
    [ApiController]
    [Route("Entidade/tb01")]
    public class EntidadeController : ControllerBase
    {
        private readonly Context _context;

        public EntidadeController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> ConsultarEntidadeAsync()
        {
            var response = await _context
                .Entidades
                .OrderByDescending(e => e.Data)
                .Take(10)
                .ToListAsync();

            return Ok(response);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> AdicionarEntidadeAsync([FromQuery] string texto)
        {
            var novaEntidade = new Entidade
            {
                Texto = texto
            };

            _context.Add(novaEntidade);

            await _context.SaveChangesAsync();

            return Ok(novaEntidade);
        }

        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> ExcluirEntidadeAsync([FromBody] ExcluirEntidade request)
        {
            var entidade = await _context.Entidades.FindAsync(request.Id);

            if (entidade == null)
            {
                return NotFound($"O {request.Id} não está cadastrado.");
            }

            _context.Entidades.Remove(entidade);

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> AtualizarEntidadeAsync([FromBody] AtualizarEntidade request)
        {
            var entidade = await _context.Entidades.FindAsync(request.Id);

            if (entidade == null)
            {
                return NotFound($"O registro com o {request.Id} não foi encontrado.");
            }

            entidade.Texto = request.Texto;
            entidade.Data = DateTime.Now;

            await _context.SaveChangesAsync();

            return Ok(entidade);
        }
    }
}
