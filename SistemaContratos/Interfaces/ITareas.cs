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
        Task<ICollection<Tarea>> GetTareas();

        Task<Tarea> GetTareaById(int tareaId);

        bool BuscarTareaTitulo(string titulo);

        bool BuscarTareaId(int tareaId);

        bool CreateTarea(Tarea Tarea);

        bool UpdateTarea(Tarea Tarea);


        bool DeleteTarea(Tarea Tarea);

        bool Save();
    }
}
