using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaTareas.DTOs
{
    public class TareasReadDTO
    {
       // public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripción { get; set; }
        public string Estado { get; set; }
    }
}
