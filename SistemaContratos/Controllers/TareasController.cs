using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaContratos.Models;
using SistemaTareas.Interfaces;


namespace SistemaContratos.Controllers
{
    [Route("[controller]")]
    public class TareasController : ControllerBase
    {
        private readonly ITareas _context;

        public TareasController(ITareas Context)
        {
            _context = Context;
        }

        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tarea>>> GetTareas()
        {
            var tarea =  await _context.GetTareas();
            return Ok(tarea);
            
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tarea>> GetTareaById(int id)
        {
            var tarea = await _context.GetTareaById(id);

            if (tarea==null)
            {
                return NotFound();
            }

            return Ok(tarea);
        }

        // POST /controller
        [HttpPost]
        public ActionResult<Tarea> CreateTarea(Tarea tar)
        {
             _context.CreateTarea(tar);
             return CreatedAtRoute(nameof(GetTareaById), new { Id = tar.Id}, tar);
        }

        // PUT /controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
