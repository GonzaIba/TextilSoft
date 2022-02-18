using AutoMapper;
using Contracts.Services;
using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Mapper
{
    public class MapperHelper : Profile
    {
        public MapperHelper()
        {
            CreateMap<ProveedoresModel, ProveedoresEntity>().ReverseMap();

            CreateMap<ClientesModel, ClientesEntity>().ReverseMap();

        }
    }
}
