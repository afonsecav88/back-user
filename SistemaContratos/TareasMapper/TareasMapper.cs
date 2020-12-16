using AutoMapper;
using SistemaContratos.DTOs;
using SistemaContratos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaTareas.TareasMapper
{
    public class TareasMapper: Profile
    {
      
        //En esta clase declaro el mapeo de un modelo tarea a un DTO Tarea o viceversa
        public TareasMapper( IMapper mapper)
        {
            CreateMap<Tarea, TareasDTO>().ReverseMap();
        }

    }
}
