using AutoMapper;
using Clase8.Jugueteria.Api.Models;
using Clase8.Jugueteria.Logica;
using Clase8.Jugueteria.Logica.Entidades;
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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Juguete>))]
        public IActionResult Get()
        {
            var juguetes = _mapper.ProjectTo<Juguete>(_juguetesLogica.ObtenerJuguetes().AsQueryable()).ToList();
            return Ok(juguetes);
        }

        [HttpGet("{id}", Name = "GetJuguete")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Juguete))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            var juguete = _mapper.Map<Juguete>(_juguetesLogica.ObtenerJuguete(id));
            if (juguete == null)
            {
                return NotFound();
            }
            return Ok(juguete);
        }

        [HttpPost(Name = "CreateJuguete")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody] Models.Juguete juguete)
        {
            var jugueteEntidad = _mapper.Map<JugueteEntidad>(juguete);
            _juguetesLogica.CrearJuguete(jugueteEntidad);
            return CreatedAtRoute("GetJuguete", new { id = juguete.Id }, juguete);
        }

        [HttpPut("{id}", Name = "UpdateJuguete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Put(int id, [FromBody] Models.Juguete juguete)
        {
            try
            {
                juguete.Id = id;
                var jugueteEntidad = _mapper.Map<JugueteEntidad>(juguete);
                var resultado = _juguetesLogica.ActualizarJuguete(jugueteEntidad);

                if (resultado == null)
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
            return Ok(juguete);
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
