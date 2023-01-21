using AutoMapper;
using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.TextilSoft.Mapeo
{
    public class BusinessMapping : Profile
    {
        public BusinessMapping()
        {
            CreateMap<ProveedoresEntity, ProveedoresModel>()
               .ForMember(x => x.ID_Proveedor, opt => opt.Ignore())
               .ReverseMap();

            CreateMap<ProductosProveedorEntity, ProductosProveedorModel>().ReverseMap();

            CreateMap<ClientesModel, ClientesEntity>().ReverseMap();
        }
    }
}
