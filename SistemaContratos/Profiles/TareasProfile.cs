using AutoMapper;
using ListaTareas.DTOs;
using ListaTareas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaTareas.Profiles
{
    public class TareasProfile: Profile
    {
      
        //En esta clase declaro el mapeo de un modelo tarea a un DTO Tarea o viceversa
        public TareasProfile( IMapper mapper)
        {
            CreateMap<Tarea,TareasReadDTO>().ReverseMap();
        }

        public TareasProfile()
        {

        }
    }
}
