using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Business.Models;
using API.Carros.ViewModels;
using AutoMapper;

namespace API.Carros.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Viagem, ViagemViewModel>().ReverseMap();
        }
    }
}
