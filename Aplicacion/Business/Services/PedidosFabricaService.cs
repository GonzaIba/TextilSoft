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

namespace Business.Services
{
    public class PedidosFabricaService : GenericService<PedidosFabricaModel>, IPedidosFabricaService
    {
        private readonly IMapper _mapper;
        private readonly IEmpleadosService _empleadosService;
        public PedidosFabricaService(IUnitOfWork unitOfWork, IMapper mapper, IEmpleadosService empleadosService)
            : base(unitOfWork, unitOfWork.GetRepository<IPedidosFabricaRepository>())
        {
            _mapper = mapper;
            _empleadosService = empleadosService;
        }

        public string CrearPedidoParaFabrica(int DNIEmpleado, List<DetallePedidosFabricaModel> detallePedidos)
        {
            PedidosFabricaModel pedidosModel = new();
            try
            {
                var detallePedidoRepository = _unitOfWork.GetRepository<IDetallePedidosFabricaRepository>();
                var productoRepository = _unitOfWork.GetRepository<IProductosRepository>();

                var empleado = _empleadosService.Get(x => x.DNI == DNIEmpleado, tracking: false).FirstOrDefault();
                if (empleado == null)
                    return "El empleado no existe";

                pedidosModel.ID_Empleados = empleado.ID_Empleados;
                pedidosModel.CreateUser = empleado.ID_Empleados;

                Crear(pedidosModel);
                _unitOfWork.SaveChanges();
                foreach (var detallePedido in detallePedidos)
                {
                    detallePedido.ID_PedidosFabrica = pedidosModel.ID_PedidosFabrica;
                    detallePedidoRepository.Insert(detallePedido);
                    _unitOfWork.SaveChanges();
                }
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

        public PaginatedList<PedidosFabricaModel> ObtenerPedidos(int pageIndex, int pageCount, Expression<Func<PedidosFabricaModel, dynamic>> orderByExpression, Expression<Func<PedidosFabricaModel, bool>> filterExpression, string orderBy, bool ascending)
        {
            PaginatedList<PedidosFabricaModel> ListapedidosModel = new();
            try
            {
                ListapedidosModel = _repository.GetPagedElements(pageIndex, pageCount, orderByExpression, ascending, filterExpression, "Empleados", tracking: false);
                return ListapedidosModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PaginatedList<PedidosFabricaModel> ObtenerTodosLosPedidos(int pageCount)
        {
            try
            {
                var Pedidos = _repository.Get(includeProperties: "Empleados", tracking: false).ToList();
                return new PaginatedList<PedidosFabricaModel>
                {
                    TotalCount = Pedidos.Count(),
                    TotalPages = (int)Math.Ceiling(Pedidos.Count() / (double)pageCount),
                    List = Pedidos
                };
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
