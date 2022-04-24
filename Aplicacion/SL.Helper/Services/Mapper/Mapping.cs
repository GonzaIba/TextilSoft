using AutoMapper;
using Domain.Entities;
using Domain.Models;
using SL.Domain.Entities;
using SL.Domain.Model;
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
            
            
            //CreateMap<Usuario_PermisoModel, UsuarioModel>().ReverseMap();
            //CreateMap<PermisoModel, Usuario_PermisoModel>().ReverseMap();
            CreateMap<PermisoModel, Patente>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id_Permiso))
               //.ForMember(dest => dest.Permiso, opt => opt.MapFrom(src => src.Permiso))
               .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Permiso))
               .ReverseMap();
            //CreateMap<Usuario_PermisoModel, Patente>()
            //    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.PermisoModel.Id_Permiso))
            //    .ForMember(dest => dest.Permiso, opt => opt.MapFrom(src => src.PermisoModel.Permiso))
            //    .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.PermisoModel.Permiso))
            //    .ReverseMap();

            CreateMap<UsuarioModel, Usuario>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id_Usuario))
                ;
                //.ForMember(dest => dest.Permisos.ForEach(x =>x.AgregarHijo(opt)), opt => opt.MapFrom(src => new List<Usuario_PermisoModel>()));
        }
    }
}
