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
using Domain.Enum;
using System.Data.Entity.Core.Common.CommandTrees;

namespace UI.TextilSoft.Controllers
{
    public class PedidosController<T> : IPedidosController<T> where T : class
    {
        private readonly IPedidosService _pedidosService;
        private readonly IPedidosFabricaService _pedidosFabricaService;
        private readonly IClientesService _clientesService;
        private readonly IEmpleadosService _empleadosService;
        private readonly IDetallePedidosService _detallePedidosService;
        private readonly IProductoService _productoService;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;
        //private readonly IExpressionContext _expressionContext;
        public PedidosController(IPedidosService pedidosService, IClientesService clientesService, IPedidosFabricaService pedidosFabricaService, IEmpleadosService empleadosService, IDetallePedidosService detallePedidosService, IProductoService productoService, IMapper mapper, ILogger logger)
        {
            _pedidosService = pedidosService;
            _clientesService = clientesService;
            _pedidosFabricaService = pedidosFabricaService;
            _empleadosService = empleadosService;
            _detallePedidosService = detallePedidosService;
            _productoService = productoService;
            _mapper = mapper;
            _logger = logger;
        }

        public T ObtenerPedido(int NumeroOrden, ClientesEntity clienteEntity, bool EsPedido)
        {
            try
            {
                if (EsPedido)
                {
                    SeguimientoPedidosEntity pedidoEntity = new();
                    var clienteModel = _clientesService.Get(x => x.DNI == Convert.ToString(clienteEntity.DNI), tracking: false).FirstOrDefault();
                    var pedidoModel = _pedidosService.Get(x => x.NumeroPedido == NumeroOrden && x.ID_Cliente == clienteModel.ID_Cliente, includeProperties: "EstadoPedido,HistorialPedidos,HistorialPedidos.EstadoPedido", tracking: false).FirstOrDefault();
                    pedidoEntity = _mapper.Map<SeguimientoPedidosEntity>(pedidoModel);
                    return (T)(object)pedidoEntity;
                }
                else
                {
                    ListarPedidosFabricaEntity pedidoEntity = new();
                    var clienteModel = _clientesService.Get(x => x.DNI == Convert.ToString(clienteEntity.DNI), tracking: false).FirstOrDefault();
                    var pedidoModel = _pedidosService.Get(x => x.NumeroPedido == NumeroOrden && x.ID_Cliente == clienteModel.ID_Cliente, includeProperties: "EstadoPedido", tracking: false).FirstOrDefault();
                    pedidoEntity = _mapper.Map<ListarPedidosFabricaEntity>(pedidoModel);
                    return (T)(object)pedidoEntity;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ListarPedidosEntity ObtenerPedido(int NumeroPedido, ClientesEntity clienteEntity)
        {
            ListarPedidosEntity pedidoEntity = new();
            try
            {
                var clienteModel = _clientesService.Get(x => x.DNI == Convert.ToString(clienteEntity.DNI), tracking: false).FirstOrDefault();
                var pedidoModel = _pedidosService.Get(x => x.NumeroPedido == NumeroPedido && x.ID_Cliente == clienteModel.ID_Cliente, includeProperties: "EstadoPedido", tracking: false).FirstOrDefault();
                pedidoEntity = _mapper.Map<ListarPedidosEntity>(pedidoModel);
                return pedidoEntity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public PaginatedList<T> ObtenerPedidos(int pageIndex, int pageCount, Expression<Func<T, bool>> filterExpression, string orderBy, bool ascending, bool EsPedido)
        {
            try
            {
                if (EsPedido)
                {
                    Expression<Func<PedidosModel, dynamic>> orderByExpressionPedidosModel = orderBy switch
                    {
                        "ID_Pedido" => entity => entity.ID_Pedido,
                        "NumeroPedido" => entity => entity.NumeroPedido,
                        "SubTotal" => entity => entity.SubTotal,
                        "Fecha" => entity => entity.Fecha,
                        "Seña" => entity => entity.Seña,
                        "Cliente" => entity => entity.Clientes.Nombre,
                        "AtendidoPor" => entity => entity.Empleados.Nombre,
                        "EstadoPedido" => entity => entity.EstadoPedido,
                        _ => entity => entity.ID_Pedido,
                    };
                    //var orderByExpressionPedidosModel = orderByExpression.ReplaceParameter<ListarPedidosEntity, PedidosModel>();
                    var filterExpressionPedidosModel = filterExpression.ReplaceParameter<T, PedidosModel>();
                    var ListaPedidosModel = _pedidosService.ObtenerPedidos(pageIndex, pageCount, orderByExpressionPedidosModel, filterExpressionPedidosModel, orderBy, ascending);
                    var ListaPedidosEntity = new PaginatedList<ListarPedidosEntity>();
                    ListaPedidosEntity.List = _mapper.Map<List<ListarPedidosEntity>>(ListaPedidosModel.List.ToList());
                    ListaPedidosEntity.TotalCount = ListaPedidosModel.TotalCount;
                    ListaPedidosEntity.TotalPages = ListaPedidosModel.TotalPages;
                    //ListaPedidosModel.List.ToList().ForEach(listaPedidos => ListaPedidosEntity.List.ToList().Add(_mapper.Map<ListarPedidosEntity>(listaPedidos)));
                    return (PaginatedList<T>)(object)ListaPedidosEntity;
                }
                else
                {
                    Expression<Func<PedidosFabricaModel, dynamic>> orderByExpressionPedidosModel = orderBy switch
                    {
                        "ID_PedidosFabrica" => entity => entity.ID_PedidosFabrica,
                        "Detalle" => entity => entity.Detalle,
                        "AtendidoPor" => entity => entity.Empleados.Nombre,
                        _ => entity => entity.ID_PedidosFabrica,
                    };
                    //var orderByExpressionPedidosModel = orderByExpression.ReplaceParameter<ListarPedidosEntity, PedidosModel>();
                    var filterExpressionPedidosModel = filterExpression.ReplaceParameter<T, PedidosFabricaModel>();
                    var ListaPedidosModel = _pedidosFabricaService.ObtenerPedidos(pageIndex, pageCount, orderByExpressionPedidosModel, filterExpressionPedidosModel, orderBy, ascending);
                    var ListaPedidosEntity = new PaginatedList<ListarPedidosFabricaEntity>();
                    ListaPedidosEntity.List = _mapper.Map<List<ListarPedidosFabricaEntity>>(ListaPedidosModel.List.ToList());
                    ListaPedidosEntity.TotalCount = ListaPedidosModel.TotalCount;
                    ListaPedidosEntity.TotalPages = ListaPedidosModel.TotalPages;
                    //ListaPedidosModel.List.ToList().ForEach(listaPedidos => ListaPedidosEntity.List.ToList().Add(_mapper.Map<ListarPedidosEntity>(listaPedidos)));
                    return (PaginatedList<T>)(object)ListaPedidosEntity;
                }
            }
            catch (Exception ex)
            {
                _logger.GenerateFatalLog("Ocurrió un error fatal al obtener pedidos",ex);
                throw;
            }
        }

        public PaginatedList<T> ObtenerListaPedidos(int pageCount, bool EsPedido)
        {
            try
            {
                if(EsPedido)
                {
                    var ListaPedidosModel = _pedidosService.ObtenerTodosLosPedidos(pageCount);
                    var ListaPedidosEntity = new PaginatedList<ListarPedidosEntity>();
                    ListaPedidosEntity.List = _mapper.Map<List<ListarPedidosEntity>>(ListaPedidosModel.List.ToList());
                    ListaPedidosEntity.TotalCount = ListaPedidosModel.TotalCount;
                    ListaPedidosEntity.TotalPages = ListaPedidosModel.TotalPages;
                    return (PaginatedList<T>)(object)ListaPedidosEntity;
                }
                else
                {
                    var ListaPedidosModel = _pedidosFabricaService.ObtenerTodosLosPedidos(pageCount);
                    var ListaPedidosEntity = new PaginatedList<ListarPedidosFabricaEntity>();
                    ListaPedidosEntity.List = _mapper.Map<List<ListarPedidosFabricaEntity>>(ListaPedidosModel.List.ToList());
                    ListaPedidosEntity.TotalCount = ListaPedidosModel.TotalCount;
                    ListaPedidosEntity.TotalPages = ListaPedidosModel.TotalPages;
                    return (PaginatedList<T>)(object)ListaPedidosEntity;
                }
            }
            catch (Exception ex)
            {
                _logger.GenerateFatalLog("Ocurrió un error fatal al obtener todos los pedidos", ex);
                throw ex;
            }
        }
        
        public string GenerarPedido(List<DetallePedidosYFabricaEntity> listaPedidos, bool EsPedido, int DNIEmpleado ,int DNICLiente = 0, decimal subtotal = 0, decimal seña = 0)
        {
            string Mensaje = string.Empty;
            try
            {
                if (EsPedido)
                {
                    List<DetallePedidosModel> ListadetallePedidosModel = new();
                    foreach (var item in listaPedidos)
                    {
                        DetallePedidosModel detallePedidosModel = new();
                        detallePedidosModel.Cantidad = item.Cantidad;
                        detallePedidosModel.Detalle = item.Detalle;
                        var producto = _productoService.Get(x => x.CodigoProducto == item.Codigo, tracking: false).FirstOrDefault();
                        if(producto != null)
                        {
                            detallePedidosModel.ID_Producto = producto.ID_Producto;
                            ListadetallePedidosModel.Add(detallePedidosModel);
                        }
                    }
                    return _pedidosService.CrearPedido(DNICLiente, DNIEmpleado, subtotal, ListadetallePedidosModel,seña);   
                }
                else
                {
                    List<DetallePedidosFabricaModel> ListadetallePedidosModel = new();
                    foreach (var item in listaPedidos)
                    {
                        DetallePedidosFabricaModel detallePedidosModel = new();
                        detallePedidosModel.Cantidad = item.Cantidad;
                        detallePedidosModel.Detalle = item.Detalle;
                        var producto = _productoService.Get(x => x.CodigoProducto == item.Codigo, tracking: false).FirstOrDefault();
                        if (producto != null)
                        {
                            detallePedidosModel.ID_Producto = producto.ID_Producto;
                            ListadetallePedidosModel.Add(detallePedidosModel);
                        }
                    }
                    return _pedidosFabricaService.CrearPedidoParaFabrica(DNIEmpleado, ListadetallePedidosModel);
                }
            }
            catch (Exception ex)
            {
                _logger.GenerateFatalLog("Ocurrió un error fatal al crear el pedido", ex);
                return "Ocurrió un error fatal al crear el pedido, contacte con el administrador por favor";
            }
        }

        public PaginatedList<T> ObtenerPedidosParaODT(int pageIndex, int pageCount, string orderBy, bool ascending, bool EsPedido)
        {
            try
            {
                if (EsPedido)
                {
                    Expression<Func<PedidosModel, dynamic>> orderByExpressionPedidosModel = orderBy switch
                    {
                        "ID_Pedido" => entity => entity.ID_Pedido,
                        "NumeroPedido" => entity => entity.NumeroPedido,
                        "SubTotal" => entity => entity.SubTotal,
                        "Fecha" => entity => entity.Fecha,
                        "Seña" => entity => entity.Seña,
                        "Cliente" => entity => entity.Clientes.Nombre,
                        "AtendidoPor" => entity => entity.Empleados.Nombre,
                        "EstadoPedido" => entity => entity.EstadoPedido,
                        _ => entity => entity.ID_Pedido,
                    };                
                    Expression<Func<PedidosModel, bool>> expression = x => x.ID_EstadoPedido == (int)EstadoPedidosEnum.SinAsignar;
                    var ListaPedidosModel = _pedidosService.ObtenerPedidos(pageIndex, pageCount, orderByExpressionPedidosModel, expression, orderBy, ascending);
                    var ListaPedidosEntity = new PaginatedList<ListarPedidosEntity>();
                    ListaPedidosEntity.List = _mapper.Map<List<ListarPedidosEntity>>(ListaPedidosModel.List.ToList());
                    ListaPedidosEntity.TotalCount = ListaPedidosModel.TotalCount;
                    ListaPedidosEntity.TotalPages = ListaPedidosModel.TotalPages;
                    return (PaginatedList<T>)(object)ListaPedidosEntity;
                }
                else
                {
                    Expression<Func<PedidosFabricaModel, dynamic>> orderByExpressionPedidosModel = orderBy switch
                    {
                        "ID_PedidosFabrica" => entity => entity.ID_PedidosFabrica,
                        "Detalle" => entity => entity.Detalle,
                        "AtendidoPor" => entity => entity.Empleados.Nombre,
                        _ => entity => entity.ID_PedidosFabrica,
                    };
                    Expression<Func<PedidosFabricaModel, bool>> expression = x => x.ID_EstadoPedidoFabrica == (int)EstadoPedidosFabricaEnum.SinAsignar;
                    var ListaPedidosModel = _pedidosFabricaService.ObtenerPedidos(pageIndex, pageCount, orderByExpressionPedidosModel, expression, orderBy, ascending);
                    var ListaPedidosEntity = new PaginatedList<ListarPedidosFabricaEntity>();
                    ListaPedidosEntity.List = _mapper.Map<List<ListarPedidosFabricaEntity>>(ListaPedidosModel.List.ToList());
                    ListaPedidosEntity.TotalCount = ListaPedidosModel.TotalCount;
                    ListaPedidosEntity.TotalPages = ListaPedidosModel.TotalPages;
                    //ListaPedidosModel.List.ToList().ForEach(listaPedidos => ListaPedidosEntity.List.ToList().Add(_mapper.Map<ListarPedidosEntity>(listaPedidos)));
                    return (PaginatedList<T>)(object)ListaPedidosEntity;
                }
            }
            catch (Exception ex)
            {
                _logger.GenerateFatalLog("Ocurrió un error fatal al obtener pedidos", ex);
                throw;
            }
        }

        public void AsignarODT(int idPedido, bool EsPedido)
        {
            try
            {
                if (EsPedido)
                {
                    _pedidosService.AsignarODT(idPedido);

                }
                else
                {
                    _pedidosFabricaService.AsignarODT(idPedido);
                    var pedido = _pedidosFabricaService.Get(x => x.ID_PedidosFabrica == idPedido, tracking: true).FirstOrDefault();
                    pedido.ID_EstadoPedidoFabrica = (int)EstadoPedidosFabricaEnum.EnProduccion;
                    _pedidosFabricaService.Actualizar(pedido);
                }
            }
            catch (Exception ex)
            {
                _logger.GenerateFatalLog("Ocurrió un error fatal al asignar el pedido", ex);
                throw ex;
            }
        }
    }
}
