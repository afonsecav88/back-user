using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaContratos.DTOs
{
    public class TareasDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripción { get; set; }
        public string Estado { get; set; }
    }
}
