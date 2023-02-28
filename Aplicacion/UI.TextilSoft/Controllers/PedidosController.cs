using AutoMapper;
using AutoMapper.Internal;
using Business.Services;
using Contracts.Controllers;
using Contracts.Services;
using Domain.Entities;
using Domain.GenericEntity;
using Domain.Models;
using log4net.Core;
using SL.Helper.Extensions;
using SL.Helper.Services.Log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;
using ILogger = SL.Helper.Services.Log4net.ILogger;

namespace UI.TextilSoft.Controllers
{
    public class PedidosController : IPedidosController
    {
        private readonly IPedidosService _pedidosService;
        private readonly IClientesService _clientesService;
        private readonly IEmpleadosService _empleadosService;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;
        //private readonly IExpressionContext _expressionContext;
        public PedidosController(IPedidosService pedidosService, IClientesService clientesService, IEmpleadosService empleadosService, IMapper mapper, ILogger logger)
        {
            _pedidosService = pedidosService;
            _clientesService = clientesService;
            _empleadosService = empleadosService;
            _mapper = mapper;
            _logger = logger;
        }

        public ListarPedidosEntity ObtenerPedido(int Numeropedido, ClientesEntity clienteEntity)
        {
            ListarPedidosEntity pedidoEntity = new();
            try
            {
                var clienteModel = _clientesService.Get(x => x.DNI == Convert.ToString(clienteEntity.DNI), tracking: false).FirstOrDefault();
                var pedidoModel = _pedidosService.Get(x => x.NumeroPedido == Numeropedido && x.ID_Cliente == clienteModel.ID_Cliente, includeProperties: "EstadoPedido", tracking: false).FirstOrDefault();
                pedidoEntity = _mapper.Map<ListarPedidosEntity>(pedidoModel);
                return pedidoEntity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PaginatedList<ListarPedidosEntity> ObtenerPedidos(int pageIndex, int pageCount, Expression<Func<ListarPedidosEntity, bool>> filterExpression, string orderBy, bool ascending)
        {
            try
            {
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
                var ListaPedidosEntity = new PaginatedList<ListarPedidosEntity>();
                ListaPedidosEntity.List = _mapper.Map<List<ListarPedidosEntity>>(ListaPedidosModel.List.ToList());
                ListaPedidosEntity.TotalCount = ListaPedidosModel.TotalCount;
                ListaPedidosEntity.TotalPages = ListaPedidosModel.TotalPages;
                //ListaPedidosModel.List.ToList().ForEach(listaPedidos => ListaPedidosEntity.List.ToList().Add(_mapper.Map<ListarPedidosEntity>(listaPedidos)));
                return ListaPedidosEntity;
            }
            catch (Exception ex)
            {
                _logger.GenerateFatalLog("Ocurrió un error fatal al obtener pedidos",ex);
                throw;
            }
        }

        public PaginatedList<ListarPedidosEntity> ObtenerListaPedidos(int pageCount)
        {
            try
            {
                var ListaPedidosModel = _pedidosService.ObtenerTodosLosPedidos(pageCount);
                var ListaPedidosEntity = new PaginatedList<ListarPedidosEntity>();
                ListaPedidosEntity.List = _mapper.Map<List<ListarPedidosEntity>>(ListaPedidosModel.List.ToList());
                ListaPedidosEntity.TotalCount = ListaPedidosModel.TotalCount;
                ListaPedidosEntity.TotalPages = ListaPedidosModel.TotalPages;
                return ListaPedidosEntity;
            }
            catch (Exception ex)
            {
                _logger.GenerateFatalLog("Ocurrió un error fatal al obtener todos los pedidos", ex);
                throw ex;
            }
        }
    }
}
