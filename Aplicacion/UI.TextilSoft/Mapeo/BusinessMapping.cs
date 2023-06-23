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
                .ForMember(dest => dest.NombreProducto, opt => opt.MapFrom(src => src.Descripcion))
                .ForMember(dest => dest.TallePrenda, opt => opt.MapFrom(src => src.TallePrenda))
                .ForMember(dest => dest.ImagenPrenda, opt => opt.MapFrom(src => src.ImagenPrenda))
                .ForMember(dest => dest.TipoPrenda, opt => opt.MapFrom(src => src.TipoPrenda.TipoPrenda))
                .ForMember(dest => dest.TelaBase, opt => opt.MapFrom(src => src.TelaBase.Nombre))
                .ForMember(dest => dest.TelaCombinacion, opt => opt.MapFrom(src => src.TelaCombinacion.Nombre))
                .ForMember(dest => dest.BolsilloInterior, opt => opt.MapFrom(src => src.BolsilloInterior.Nombre))
                .ForMember(dest => dest.Lazo, opt => opt.MapFrom(src => src.Lazo.Nombre))
                .ForMember(dest => dest.Vivo, opt => opt.MapFrom(src => src.Vivo.Nombre))
                .ForMember(dest => dest.Precio, opt => opt.MapFrom(src => src.Precio))
                .ForMember(dest => dest.Stock, opt => opt.MapFrom(src => src.Stock))
                .ForMember(dest => dest.Composicion, opt => opt.MapFrom(src => src.Composicion))
                .ForMember(dest => dest.Transfer, opt => opt.MapFrom(src => src.Transfer.Codigo))
                .ReverseMap();

            CreateMap<ProductosModel, ProductoGrillaEntity>()
                .ForMember(dest => dest.ID_Producto, opt => opt.MapFrom(src => src.ID_Producto))
                .ForMember(dest => dest.Codigo, opt => opt.MapFrom(src => src.CodigoProducto))
                .ForMember(dest => dest.Color, opt => opt.MapFrom(src => ConvertToColor(src.Color)))
                .ForMember(dest => dest.NombreProducto, opt => opt.MapFrom(src => src.Descripcion))
                .ForMember(dest => dest.Precio, opt => opt.MapFrom(src => src.Precio))
                .ForMember(dest => dest.Stock, opt => opt.MapFrom(src => src.Stock))
                .ForMember(dest => dest.Acciones, opt => opt.MapFrom("      Ver Detalle"))
                .ReverseMap();

            CreateMap<PedidosModel, ListarPedidosEntity>()
                .ForMember(dest => dest.PedidoID, opt => opt.MapFrom(src => "      " + Convert.ToString(src.ID_Pedido)))
                .ForMember(dest => dest.NroPedido, opt => opt.MapFrom(src => src.NumeroPedido))
                .ForMember(dest => dest.EstadoPedido, opt => opt.MapFrom(src => ConvertToEstadoPedido(src.EstadoPedido.ID_EstadoPedido)))
                .ForMember(dest => dest.AtendidoPor, opt => opt.MapFrom(src => src.Empleados.Nombre + " " + src.Empleados.Apellido))
                .ForMember(dest => dest.Cliente, opt => opt.MapFrom(src => src.Clientes.Nombre + " " + src.Clientes.Apellido))
                .ReverseMap()
                .ForMember(dest => dest.ID_Pedido, opt => opt.MapFrom(src => "      "+ src.PedidoID))
                .ForMember(dest => dest.Empleados, opt => opt.MapFrom(src => new EmpleadosModel { Nombre = StringSepare(src.AtendidoPor, " ", 0), Apellido = StringSepare(src.AtendidoPor, " ", 1) }))
                .ForMember(dest => dest.Clientes, opt => opt.MapFrom(src => new ClientesModel { Nombre = StringSepare(src.Cliente, " ", 0), Apellido = StringSepare(src.Cliente, " ", 1) }));

            CreateMap<PedidosFabricaModel, ListarPedidosFabricaEntity>()
                .ForMember(dest => dest.PedidoID, opt => opt.MapFrom(src => "      " + Convert.ToString(src.ID_EstadoPedidoFabrica)))
                .ForMember(dest => dest.EstadoPedidos, opt => opt.MapFrom(src => ConvertToEstadoPedido(src.EstadoPedidoFabrica.ID_EstadoPedidoFabrica)))
                .ForMember(dest => dest.AtendidoPor, opt => opt.MapFrom(src => src.Empleados.Nombre + " " + src.Empleados.Apellido))
                .ReverseMap()
                .ForMember(dest => dest.ID_PedidosFabrica, opt => opt.MapFrom(src => "      " + src.PedidoID))
                .ForMember(dest => dest.Empleados, opt => opt.MapFrom(src => new EmpleadosModel { Nombre = StringSepare(src.AtendidoPor, " ", 0), Apellido = StringSepare(src.AtendidoPor, " ", 1) }));

            CreateMap<List<DetallePedidosYFabricaEntity>, List<DetallePedidosFabricaModel>>()
                .ReverseMap();

            CreateMap<List<DetallePedidosYFabricaEntity>, List<DetallePedidosModel>>()
                .ReverseMap();

            CreateMap<PedidosModel, SeguimientoPedidosEntity>()
                .ForMember(dest => dest.NumeroPedido, opt => opt.MapFrom(src => src.NumeroPedido))
                .ForMember(dest => dest.EstadoActual, opt => opt.MapFrom(src => ConvertToEstadoPedido(src.EstadoPedido.ID_EstadoPedido)))
                .ForMember(dest => dest.HistorialPedidos, opt => opt.MapFrom(src => src.HistorialPedidos.Select(hp => new HistorialPedidosEntity { EstadoPedido = ConvertToEstadoPedido(hp.EstadoPedido.ID_EstadoPedido), Fecha = hp.Fecha }).ToList()));

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
