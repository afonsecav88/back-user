using SistemaContratos.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTareas.Interfaces
{
    public interface ITareas
    {
     Task<IEnumerable<Tarea>> GetTareas();

        Task<Tarea> GetTareaById(int id);

        void CreateTarea(Tarea Tarea);

        void UpdateTarea(Tarea Tarea);

        void DeleteTarea(Tarea Tarea);


    }
}
