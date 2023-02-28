using AutoMapper;
using Contracts.Repositories;
using Contracts.Services;
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
        public PedidosService(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork, unitOfWork.GetRepository<IPedidosRepository>())
        {
            _mapper = mapper;
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
    }
}
