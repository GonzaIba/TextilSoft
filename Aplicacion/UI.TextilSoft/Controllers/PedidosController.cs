using AutoMapper;
using AutoMapper.Internal;
using Business.Services;
using Contracts.Controllers;
using Contracts.Services;
using Domain.Entities;
using Domain.Models;
using log4net.Core;
using SL.Helper.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UI.TextilSoft.Controllers
{
    public class PedidosController : IPedidosController
    {
        private readonly IPedidosService _pedidosService;
        private readonly IClientesService _clientesService;
        private readonly IEmpleadosService _empleadosService;
        private readonly IMapper _mapper;
        public PedidosController(IPedidosService pedidosService, IClientesService clientesService, IEmpleadosService empleadosService, IMapper mapper)
        {
            _pedidosService = pedidosService;
            _clientesService = clientesService;
            _empleadosService = empleadosService;
            _mapper = mapper;
        }

        public ListarPedidosEntity ObtenerPedido(int Numeropedido, ClientesEntity clienteEntity)
        {
            ListarPedidosEntity pedidoEntity = new();
            try
            {
                var clienteModel = _clientesService.Get(x => x.DNI == Convert.ToString(clienteEntity.DNI)).FirstOrDefault();
                var pedidoModel = _pedidosService.Get(x => x.NumeroPedido == Numeropedido && x.ID_Cliente == clienteModel.ID_Cliente, includeProperties:"EstadoPedido").FirstOrDefault();
                pedidoEntity = _mapper.Map<ListarPedidosEntity>(pedidoModel);
                return pedidoEntity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ListarPedidosEntity> ObtenerPedidos(int pageIndex, int pageCount, Expression<Func<ListarPedidosEntity, bool>> filterExpression, string orderBy, bool ascending)
        {
            //Expression<Func<ListarPedidosEntity, dynamic>> orderByExpression = orderBy switch
            //{
            //    "ID_Pedido" => entity => entity.ID_Pedido,
            //    "NumeroPedido" => entity => entity.NumeroPedido,
            //    "TotalPago" => entity => entity.TotalPago,
            //    "Fecha" => entity => entity.Fecha,
            //    "Seña" => entity => entity.Seña,
            //    _ => entity => entity.ID_Pedido,
            //};
            Expression<Func<PedidosModel, dynamic>> orderByExpressionPedidosModel = orderBy switch
            {
                "ID_Pedido" => entity => entity.ID_Pedido,
                "NumeroPedido" => entity => entity.NumeroPedido,
                "TotalPago" => entity => entity.TotalPago,
                "Fecha" => entity => entity.Fecha,
                "Seña" => entity => entity.Seña,
                "Cliente" => entity => entity.Clientes.Nombre,
                "AtendidoPor" => entity => entity.Empleados.Nombre,
                "EstadoPedido" => entity => entity.EstadoPedido,
                _ => entity => entity.ID_Pedido,
            };
            //var orderByExpressionPedidosModel = orderByExpression.ReplaceParameter<ListarPedidosEntity, PedidosModel>();
            var filterExpressionPedidosModel = filterExpression.ReplaceParameter<ListarPedidosEntity, PedidosModel>();
            var ListaPedidosModel = _pedidosService.ObtenerPedidos(pageIndex, pageCount, orderByExpressionPedidosModel, filterExpressionPedidosModel, orderBy, ascending);
            var ListaPedidosEntity = new List<ListarPedidosEntity>();
            ListaPedidosModel.List.ToList().ForEach(job => ListaPedidosEntity.Add(_mapper.Map<ListarPedidosEntity>(job)));
            return ListaPedidosEntity;
        }
    }
}
