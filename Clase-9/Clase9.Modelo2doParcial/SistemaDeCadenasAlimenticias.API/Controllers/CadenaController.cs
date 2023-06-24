using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using SistemaDeCadenasAlimenticias.API.Models;
using SistemaDeCadenasAlimenticias.Data.EF;
using SistemaDeCadenasAlimenticias.Servicios;

namespace SistemaDeCadenasAlimenticias.API.Controllers
{
 



    [Route("api/[controller]")]
    [ApiController]
    public class CadenaController : ControllerBase
    {

        private ICadenasServicio _cadenasServicio;
        private readonly IMapper _mapper;
        public CadenaController(ICadenasServicio cadenasServicio, IMapper mapper)
        {
            _cadenasServicio = cadenasServicio;
            _mapper = mapper;
        }
        //get

        [HttpGet(Name = "GetCadenas")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<CadenaModelApi>))]
        public IActionResult Get()
        {
            var listaDeCadenas=_cadenasServicio.Listar();
            //var listaDeCadenas = _mapper.ProjectTo<CadenaModelApi>(_cadenasServicio.Listar().AsQueryable()).ToList();

            return Ok(listaDeCadenas);
        }
        [HttpGet("{id}",Name ="GetCadena")]
        [ProducesResponseType(StatusCodes.Status200OK,Type =typeof(CadenaModelApi))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id) {
            var  result = _cadenasServicio.ObtenerCadena(id);
            // var result = _mapper.Map<CadenaModelApi>( _cadenasServicio.ObtenerCadena(id));
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpPost(Name ="CreateCadena")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody] Models.CadenaModelApi cadena) {
            var cadenaEntidad = _mapper.Map<Cadena>(cadena);
            _cadenasServicio.CrearCadena(cadenaEntidad);
            return CreatedAtRoute("GetCadena", new { id = cadenaEntidad.Id }, cadena);
            //return Ok();
        }

        [HttpDelete("{id}", Name = "DeleteCadena")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Delete(int id)
        {
            //_cadenasServicio.EliminarCadena(id);
            _cadenasServicio.EliminarCadenaInclude(id);
            return Ok();
        }

        [HttpPut("{id}", Name = "UpdateCadena")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Put(int id, [FromBody] Models.CadenaModelApi cadena) {
            //debo tomar el id del formulario/url y no usar la del objeto?
            cadena.IdCadena = id;
            var cadenaEntidad = _mapper.Map<Cadena>(cadena);
            var result=_cadenasServicio.ActualizarCadena(cadenaEntidad);
            if (result == null) { 
            return NotFound();
            }
            //return CreatedAtRoute("GetCadena", new { id = cadenaEntidad.Id }, cadena);
            return Ok(result);
        }


    }
}
