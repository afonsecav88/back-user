using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ListaTareas.DTOs;
using ListaTareas.Models;
using ListaTareas.Interfaces;


namespace ListaTareas.Controllers
{
    [Route("[controller]")]
    public class TareasController : ControllerBase
    {
        private readonly ITareas _context;
        private readonly IMapper _mapper;

        public TareasController(ITareas context,IMapper mapper )
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tarea>>> GetTareas()
        {
            var tarea = await _context.GetTareas();

            return Ok(tarea);
            
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tarea>> GetTareaById(int id)
        {
            var tarea = await _context.GetTareaById(id);

            if (tarea==null)
            {
                return NotFound("Tarea no Encontrada.");
            }

            return Ok(tarea);
        }

        // POST /controller
        [HttpPost]
        public ActionResult<Tarea> CreateTarea(Tarea tarea)
        {
             _context.CreateTarea(tarea);
             _context.SaveChanges();
             return CreatedAtRoute(nameof(GetTareaById), new { Id = tarea.Id}, tarea);
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
