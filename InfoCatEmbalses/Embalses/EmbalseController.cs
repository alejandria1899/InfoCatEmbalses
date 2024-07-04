using AutoMapper;
using InfoCatEmbalses.Data;
using InfoCatEmbalses.Embalses.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InfoCatEmbalses.Embalses
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmbalseController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IEmbalseRepository _embalseRepository;
        private readonly EmbalseService _embalseService;

        public EmbalseController(AppDbContext context, IMapper mapper, IEmbalseRepository embalseRepository, EmbalseService embalseService)
        {
            _context = context;
            _mapper = mapper;
            _embalseRepository = embalseRepository;
            _embalseService = embalseService;
        }

        [HttpGet("importar-datos")]
        public async Task<IActionResult> ImportarDatos()
        {
            await _embalseService.ImportarDatosAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<List<EmbalseDto>>> GetAllEmbalse()
        {
            var embalses = await _embalseRepository.GetAllEmbalse();
            _mapper.Map<List<EmbalseDto>>(embalses);
            return Ok(embalses);
        }
        
        [HttpGet("ultimos-cinco-dias")]
        public async Task<ActionResult<List<EmbalseDto>>> GetAllFromLast5Days()
        {
            var embalses = await _embalseRepository.GetAllFromLast5Days();
            var embalsesDto = _mapper.Map<List<EmbalseDto>>(embalses);
            return Ok(embalsesDto);
        }
        

        [HttpPost]
        public async Task<ActionResult<List<EmbalseDto>>> CreateEmbalse(EmbalseCreateDto embalseCreateDto)
        {
            var embalse = _mapper.Map<Embalse>(embalseCreateDto);
            await _embalseRepository.CreateEmbalse(embalse);
            return Ok(embalse);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateEmbalse(int id, [FromBody] EmbalseCreateDto updateEmbalseDto)
        {
            var embalse = await _context.Embalses.FindAsync(id);
            if (embalse == null)
            {
                return NotFound();
            }

            _mapper.Map(updateEmbalseDto, embalse);
            await _embalseRepository.UpdateEmbalse(embalse);
            return Ok(embalse);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteEmbalse(int id)
        {
            var embalse = await _context.Embalses.FindAsync(id);
            if (embalse == null)
            {
                return NotFound();
            }

            _context.Embalses.Remove(embalse);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
