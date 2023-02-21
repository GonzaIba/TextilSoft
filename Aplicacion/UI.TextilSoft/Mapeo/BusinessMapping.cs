using AutoMapper;
using Domain.Entities;
using Domain.Enum;
using Domain.Models;
using SL.Domain.Enums;
using System;
using System.Collections.Generic;
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

            CreateMap<PedidosModel, ListarPedidosEntity>()
                .ForMember(x => x.EstadoPedido, opt => opt.MapFrom(src => ConvertToEstadoPedido(src.EstadoPedido.ID_EstadoPedido)))
                .ForMember(x => x.AtendidoPor, opt => opt.MapFrom(src => src.Empleados.Nombre + " " + src.Empleados.Apellido))
                .ForMember(x => x.Cliente, opt => opt.MapFrom(src => src.Clientes.Nombre + " " + src.Clientes.Apellido))
                .ReverseMap();

            //map Expression<Func<PedidosModel, bool>> to Expression<Func<PedidosModel, bool>>>
            //CreateMap<Expression<Func<PedidosModel, bool>>, Expression<Func<ListarPedidosEntity, bool>>>()
            //    .ConvertUsing<ExpressionConverter<PedidosModel, ListarPedidosEntity>>();


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
    }
}
