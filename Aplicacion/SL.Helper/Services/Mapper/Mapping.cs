using AutoMapper;
using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Helper.Services.Mapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<ProveedoresModel, ProveedoresEntity>().ReverseMap();
            CreateMap<ClientesModel, ClientesEntity>().ReverseMap();
        }
    }
}
