using Microsoft.EntityFrameworkCore;
using SistemaContratos.Models;
using SistemaTareas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTareas.Services
{
    public class Tareas : ITareas
    {
        private readonly ListaTareasContext _context;

        public Tareas(ListaTareasContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Tarea>> GetTareas()
        {
            return await _context.Tareas.ToListAsync();         
        }


        public async Task<Tarea> GetTareaById(int id)
        {
            return await _context.Tareas.FirstOrDefaultAsync(x=>x.Id==id);
        }

        public void CreateTarea(Tarea Tarea)
        {
            if (Tarea==null)
            {
                throw new ArgumentNullException(nameof(Tarea));  
            };
          
          _context.Tareas.Add(Tarea);
           _context.SaveChanges();
               
        }

        public void DeleteTarea(Tarea Tarea)
        {
            throw new NotImplementedException();
        }
        
       
        public void UpdateTarea(Tarea Tarea)
        {
            throw new NotImplementedException();
        }
       
    }
}
