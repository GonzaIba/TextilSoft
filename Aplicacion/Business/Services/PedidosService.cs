using AutoMapper;
using Contracts.Repositories;
using Contracts.Services;
using Domain.Enum;
using Domain.GenericEntity;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Business.Services
{
    public class PedidosService : GenericService<PedidosModel>, IPedidosService
    {
        private readonly IMapper _mapper;
        private readonly IClientesService _clientesService;
        private readonly IEmpleadosService _empleadosService;
        public PedidosService(IUnitOfWork unitOfWork, IMapper mapper, IClientesService clientesService, IEmpleadosService empleadosService)
            : base(unitOfWork, unitOfWork.GetRepository<IPedidosRepository>())
        {
            _mapper = mapper;
            _clientesService = clientesService;
            _empleadosService = empleadosService;
        }

        public void AsignarODT(int idPedido)
        {
            try
            {
                var pedido = Get(x => x.ID_Pedido == idPedido, tracking: true).FirstOrDefault();
                pedido.ID_EstadoPedido = (int)EstadoPedidosEnum.EnProducción;
                _repository.Update(pedido);

                var historialRepository = _unitOfWork.GetRepository<IHistorialPedidosRepository>();
                HistorialPedidosModel historial = new();
                historial.ID_Pedido = idPedido;
                historial.ID_EstadoPedido = (int)EstadoPedidosEnum.EnProducción;
                historial.Fecha = DateTime.Now;
                historialRepository.Insert(historial);
                
                _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string CrearPedido(int DNICLiente, int DNIEmpleado, decimal subTotal, List<DetallePedidosModel> ListadetallePedidos, decimal seña)
        {
            PedidosModel pedidosModel = new();
            HistorialPedidosModel historialPedidosModel = new();
            try
            {
                var detallePedidoRepository = _unitOfWork.GetRepository<IDetallePedidosRepository>();
                var productoRepository = _unitOfWork.GetRepository<IProductosRepository>();
                var historialRepository = _unitOfWork.GetRepository<IHistorialPedidosRepository>();

                var cliente = _clientesService.Get(x => x.DNI == Convert.ToString(DNICLiente), tracking: false).FirstOrDefault();
                if (cliente == null)
                    return "El cliente no existe";

                pedidosModel.ID_Cliente = cliente.ID_Cliente;

                var empleado = _empleadosService.Get(x => x.DNI == DNIEmpleado, tracking: false).FirstOrDefault();
                if (empleado == null)
                    return "El empleado no existe";

                pedidosModel.ID_Empleados = empleado.ID_Empleados;
                pedidosModel.ID_EstadoPedido = (int)EstadoPedidosEnum.SinAsignar;
                pedidosModel.Fecha = DateTime.Now;
                pedidosModel.NumeroPedido = ObtenerUltimoNumeroPedido() + 1;
                pedidosModel.SubTotal = subTotal;
                pedidosModel.Seña = seña;
                pedidosModel.CreateUser = empleado.ID_Empleados;

                Crear(pedidosModel);
                _unitOfWork.SaveChanges();
                foreach (var detallePedido in ListadetallePedidos)
                {
                    detallePedido.ID_Pedido = pedidosModel.ID_Pedido;
                    detallePedidoRepository.Insert(detallePedido);
                    var producto = productoRepository.Get(x => x.ID_Producto == detallePedido.ID_Producto, tracking: true).FirstOrDefault();
                    producto.Stock = producto.Stock - detallePedido.Cantidad;
                    productoRepository.Update(producto);
                    _unitOfWork.SaveChanges();
                }
                historialPedidosModel.Fecha = DateTime.Now;
                historialPedidosModel.ID_Pedido = pedidosModel.ID_Pedido;
                historialPedidosModel.ID_EstadoPedido = pedidosModel.ID_EstadoPedido;
                historialRepository.Insert(historialPedidosModel);
                _unitOfWork.SaveChanges();
                return "OK";
            }
            catch (Exception ex)
            {
                Eliminar(pedidosModel);
                _unitOfWork.SaveChanges();
                //CancelChanges(pedidosModel);
                return "Ocurrió un error al crear el pedido";
            }
        }

        public PaginatedList<PedidosModel> ObtenerPedidos(int pageIndex, int pageCount, Expression<Func<PedidosModel, dynamic>> orderByExpression, Expression<Func<PedidosModel, bool>> filterExpression, string orderBy, bool ascending)
        {
            PaginatedList<PedidosModel> ListapedidosModel = new();
            try
            {
                ListapedidosModel = _repository.GetPagedElements(pageIndex, pageCount, orderByExpression, ascending, filterExpression, "Empleados,Clientes,EstadoPedido", tracking:false);
                return ListapedidosModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PaginatedList<PedidosModel> ObtenerTodosLosPedidos(int pageCount)
        {
            try
            {
                var Pedidos = _repository.Get(includeProperties: "Empleados,Clientes,EstadoPedido", tracking: false).ToList();
                return new PaginatedList<PedidosModel>
                {
                    TotalCount = Pedidos.Count(),
                    TotalPages = (int)Math.Ceiling(Pedidos.Count() / (double)pageCount),
                    List = Pedidos
                };
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public int ObtenerUltimoNumeroPedido()
        {
            try
            {
                var pedidos = _repository.Get();
                int UltimoNumeroPedido = 0;
                if (pedidos.Any())
                {
                    UltimoNumeroPedido = pedidos.Max(x => x.NumeroPedido);
                    // Resto del código aquí
                }
                return UltimoNumeroPedido;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
