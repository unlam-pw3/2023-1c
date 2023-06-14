using AutoMapper;
using Clase8.Jugueteria.Api.Models;
using Clase8.Jugueteria.Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clase8.Jugueteria.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JuguetesController : ControllerBase
    {
        private IJuguetesLogica _juguetesLogica;
        private readonly IMapper _mapper;
        public JuguetesController(IJuguetesLogica juguetesLogica, IMapper mapper)
        {
            _juguetesLogica = juguetesLogica;
            _mapper = mapper;
        }
        
        [HttpGet(Name = "GetJuguetes")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            var juguetes= _mapper.ProjectTo<Juguete>(_juguetesLogica.ObtenerJuguetes().AsQueryable());
            return Ok(juguetes);
        }

        [HttpGet("{id}", Name = "GetJuguete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            return Ok();
        }

        [HttpPost(Name = "CreateJuguete")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody] Models.Juguete juguete)
        {
            return CreatedAtRoute("GetJuguete", new { id = juguete.Id }, juguete);
        }

        [HttpPut("{id}", Name = "UpdateJuguete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Put(int id, [FromBody] Models.Juguete juguete)
        {
            return Ok();
        }

        [HttpDelete("{id}", Name = "DeleteJuguete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
