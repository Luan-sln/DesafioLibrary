using AutoMapper;
using DesafioLibrary.Data;
using DesafioLibrary.Model;
using Microsoft.AspNetCore.Mvc;

namespace DesafioLibrary.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ObraController : ControllerBase
    {
        private AppDbContext _context;

        private IMapper _mapper;
        public ObraController(IMapper mapper, AppDbContext context)
        {
            _mapper = mapper;
            _context = context;

        }

        [HttpPost]
        public IActionResult AddObra([FromBody] CreateObrasDto obrasDto)
        {
            Obras obra = _mapper.Map<Obras>(obrasDto);
            _context.Add(obra);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaObraID), new { Id = obra.Id }, obra);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaObraID(int id)
        {
            Obras obra = _context.Obras.FirstOrDefault(obra => obra.Id == id);
            if (obra != null)
            {
                ReadObrasDto obraDto = _mapper.Map<ReadObrasDto>(obra);
                return Ok(obraDto);
            }
            return NotFound();
        }

        [HttpGet]
        public IEnumerable<Obras> RecuperaObra()
        {
            return _context.Obras;
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaObra(int id, [FromBody] UpdateObrasDto obraDto)
        {
            Obras obra = _context.Obras.FirstOrDefault(obra => obra.Id == id);
            if (obra == null)
            {
                return NotFound();
            }
            _mapper.Map(obraDto, obra);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveObra(int id)
        {
            Obras obra = _context.Obras.FirstOrDefault(obra => obra.Id == id);
            if (obra == null)
            {
                return NotFound();
            }
            _context.Remove(obra);
            _context.SaveChanges();
            return NoContent();
        }


    }
}
