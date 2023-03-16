using AutoMapper;
using AutoMapper.Internal;
using Domain.Entities;
using Domain.Enum;
using Domain.GenericEntity;
using Domain.Models;
using SL.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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

            CreateMap<ProductosModel, ProductosEntity>()
                .ForMember(dest => dest.Codigo, opt => opt.MapFrom(src => src.CodigoProducto))
                .ForMember(dest => dest.Color, opt => opt.MapFrom(src => ConvertToColor(src.Color)))
                .ReverseMap();

            CreateMap<PedidosModel, ListarPedidosEntity>()
                .ForMember(dest => dest.PedidoID, opt => opt.MapFrom(src => src.ID_Pedido))
                .ForMember(dest => dest.NroPedido, opt => opt.MapFrom(src => src.NumeroPedido))
                .ForMember(dest => dest.EstadoPedido, opt => opt.MapFrom(src => ConvertToEstadoPedido(src.EstadoPedido.ID_EstadoPedido)))
                .ForMember(dest => dest.AtendidoPor, opt => opt.MapFrom(src => src.Empleados.Nombre + " " + src.Empleados.Apellido))
                .ForMember(dest => dest.Cliente, opt => opt.MapFrom(src => src.Clientes.Nombre + " " + src.Clientes.Apellido))
                .ReverseMap()
                .ForMember(dest => dest.Empleados, opt => opt.MapFrom(src => new EmpleadosModel { Nombre = StringSepare(src.AtendidoPor, " ", 0), Apellido = StringSepare(src.AtendidoPor, " ", 1) }))
                .ForMember(dest => dest.Clientes, opt => opt.MapFrom(src => new ClientesModel { Nombre = StringSepare(src.Cliente, " ", 0), Apellido = StringSepare(src.Cliente, " ", 1) }));

            CreateMap<PedidosFabricaModel, ListarPedidosFabricaEntity>()
                .ForMember(dest => dest.PedidoID, opt => opt.MapFrom(src => src.ID_PedidosFabrica))
                .ForMember(dest => dest.EstadoPedidos, opt => opt.MapFrom(src => ConvertToEstadoPedido(src.EstadoPedidoFabrica.ID_EstadoPedidoFabrica)))
                .ForMember(dest => dest.AtendidoPor, opt => opt.MapFrom(src => src.Empleados.Nombre + " " + src.Empleados.Apellido))
                .ReverseMap()
                .ForMember(dest => dest.Empleados, opt => opt.MapFrom(src => new EmpleadosModel { Nombre = StringSepare(src.AtendidoPor, " ", 0), Apellido = StringSepare(src.AtendidoPor, " ", 1) }));

            CreateMap<List<DetallePedidosYFabricaEntity>, List<DetallePedidosFabricaModel>>()
                .ReverseMap();

            CreateMap<List<DetallePedidosYFabricaEntity>, List<DetallePedidosModel>>()
                .ReverseMap();

        }

        public string StringSepare(string text,string separe, int index)
        {
            string textReplaced;
            try
            {
                textReplaced = text.Split(separe.ToCharArray())[index];
            }
            catch (Exception ex) //Pongo primero ArgumentNullException porque ArgumentException es una subclase de ArgumentNullException
            {
                textReplaced = string.Empty;
            }
            return textReplaced;
        }

        public EstadoPedidosEnum ConvertToEstadoPedido(int src)
        {
            EstadoPedidosEnum permiso;
            try
            {
                permiso = (EstadoPedidosEnum)Enum.Parse(typeof(EstadoPedidosEnum), src.ToString());
            }
            catch (Exception ex) //Pongo primero ArgumentNullException porque ArgumentException es una subclase de ArgumentNullException
            {
                permiso = EstadoPedidosEnum.Entregado;
            }
            return permiso;
        }

        public Color ConvertToColor(string color)
        {
            try
            {
                if (color.Length == 7)
                    return ColorTranslator.FromHtml(color);
                else
                    return Color.FromName(color);
            }
            catch (Exception ex)
            {
                return Color.White;
            }
        }
    }
}
