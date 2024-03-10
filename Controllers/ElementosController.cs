using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PARCIAL1B.Models;

namespace PARCIAL1B.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElementosController : ControllerBase
    {
        private readonly Parcial1BDBContext _parcial1BDBContext;

        public ElementosController(Parcial1BDBContext Parcial1ADBContexto)
        {
            _parcial1BDBContext = Parcial1ADBContexto;

        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<Elementos> listadoElementos = (from e in _parcial1BDBContext.Elementos select e).ToList();

            if (listadoElementos.Count() == 0)
            {
                return NotFound();
            }
            return Ok(listadoElementos);
        }

        [HttpGet]
        [Route("GetById/{Id}")]

        public IActionResult Get(int Id)
        {
            Elementos? elemeto = (from e in _parcial1BDBContext.Elementos where e.ElementoID == Id select e).FirstOrDefault();

            if (elemeto == null)
            {
                return NotFound();
            }

            return Ok(elemeto);
        }

        [HttpPost]
        [Route("Add")]

        public IActionResult GuardarElemento([FromBody] Elementos elemeto)
        {
            try
            {

                _parcial1ADBContext.Autores.Add(Autor);
                _parcial1ADBContext.SaveChanges();
                return Ok(Autor);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("actualizar/{id}")]

        public IActionResult ActualizarAutor(int id, [FromBody] Autores AutorModificar)
        {
            Autores? AutorActual = (from e in _parcial1ADBContext.Autores where e.Id == id select e).FirstOrDefault();

            if (AutorActual == null)
            {
                return NotFound();
            }

            AutorActual.Nombre = AutorModificar.Nombre;

            return Ok(AutorModificar);
        }

        [HttpDelete]
        [Route("Eliminar/{id}")]

        public IActionResult EliminarAutor(int id)
        {
            Autores? Autor = (from e in _parcial1ADBContext.Autores where e.Id == id select e).FirstOrDefault();

            if (Autor == null)
            {
                return NotFound();
            }

            _parcial1ADBContext.Autores.Attach(Autor);
            _parcial1ADBContext.Autores.Remove(Autor);
            _parcial1ADBContext.SaveChanges();

            return Ok(Autor);
        }

    }

}
