using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpotifyAPI.Data;
using SpotifyAPI.Models;

namespace SpotifyCloneApi.Controllers
{
    [ApiController]
    [Route("api/musicas")]
    public class MusicasController : ControllerBase
    {
        private readonly SpotifyContext _context;

        public MusicasController(SpotifyContext context)
        {
            _context = context;
        }

        // POST: api/musicas
        [HttpPost]
        public async Task<IActionResult> CriarMusica([FromBody] Musica musica)
        {
            _context.Musicas.Add(musica);
            await _context.SaveChangesAsync();
            return Ok(musica);
        }

        // GET: api/musicas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> GetMusicas()
        {
            var musicas = await _context.Musicas
                .Select(m => new
                {
                    m.Id,
                    m.Nome,
                    m.Artista,
                    AlbumImagemBase64 = m.AlbumImagemBase64
                })
                .ToListAsync();

            return Ok(musicas);
        }
        
       [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var musica = _context.Musicas.Find(id);
            if (musica == null)
            {
                return NotFound();
            }
            return Ok(musica);
        }
    }
}
