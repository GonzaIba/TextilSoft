using AutoMapper;
using Domain.Entities;
using Domain.Models;
using SL.Domain.Entities;
using SL.Domain.Enums;
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



            CreateMap<PermisoModel, Patente>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id_Permiso))
               .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
               .ForMember(dest => dest.Permiso, opt => opt.MapFrom(src => ConvertToTipoPermiso(src.Permiso)))
               .ReverseMap();

            CreateMap<Patente, Familia>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
               .ForMember(dest => dest.Permiso, opt => opt.MapFrom(src => src.Permiso))
               .ReverseMap();

            CreateMap<Permiso_PermisoModel, Familia>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id_Permiso_Padre))
                .ReverseMap();

            CreateMap<PermisoModel, Familia>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id_Permiso))
               .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
               .ForMember(dest => dest.Permiso, opt => opt.MapFrom(src => ConvertToTipoPermiso(src.Permiso)))
               .ReverseMap();

            CreateMap<UsuarioModel, Usuario>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id_Usuario))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ReverseMap();

            CreateMap<CompanyModel, CompanyCustomizeEntity>()
                .ForMember(dest => dest.CompanyId, opt => opt.MapFrom(src => src.CompanyId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.CompanyName))
                .ForMember(dest => dest.Color, opt => opt.MapFrom(src => src.CompanyCustomize.CompanyColor))
                .ForMember(dest => dest.Logo, opt => opt.MapFrom(src => src.CompanyCustomize.CompanyLogo))
                .ReverseMap();

            CreateMap<Register, UsuarioModel>()
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Contraseña, opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.Active, opt => opt.MapFrom(src => true));
        }

        public TipoPermiso ConvertToTipoPermiso(string src)
        {
            TipoPermiso permiso;
            try
            {
                permiso = (TipoPermiso)Enum.Parse(typeof(TipoPermiso), src);
            }
            catch (ArgumentNullException ex) //Pongo primero ArgumentNullException porque ArgumentException es una subclase de ArgumentNullException
            {
                //Si entra a este if es porque es null, por ende es una familia...
                permiso = TipoPermiso.EsFamilia;
            }
            catch (ArgumentException ex)
            {
                //Si entra a este if es porque no se encontro el permiso en el enum (Esto se puede hacer a la inversa tambien... depende de cada uno como lo quiere manejar
                permiso = TipoPermiso.SinPermisos;
            }
            return permiso;
        }        
    }
}
