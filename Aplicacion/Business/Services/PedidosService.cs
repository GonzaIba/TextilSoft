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
                ListapedidosModel = _repository.GetPagedElements(pageIndex, pageCount, orderByExpression, ascending, filterExpression, "Empleados,Clientes");
                return ListapedidosModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
