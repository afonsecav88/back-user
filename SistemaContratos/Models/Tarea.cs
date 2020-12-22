using System;
using System.Collections.Generic;

#nullable disable

namespace ListaTareas.Models
{
    public partial class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripción { get; set; }
        public string Estado { get; set; }
    }
}
