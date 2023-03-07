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
    public class ProductoService : GenericService<ProductosModel>, IProductoService
    {
        private readonly IMapper _mapper;
        public ProductoService(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork, unitOfWork.GetRepository<IProductosRepository>())
        {
            _mapper = mapper;
        }
        public PaginatedList<ProductosModel> ObtenerProductos(int pageIndex, int pageCount, Expression<Func<ProductosModel, dynamic>> orderByExpression, Expression<Func<ProductosModel, bool>> filterExpression, string orderBy, bool ascending)
        {
            PaginatedList<ProductosModel> ListapedidosModel = new();
            try
            {
                ListapedidosModel = _repository.GetPagedElements(pageIndex, pageCount, orderByExpression, ascending, filterExpression, tracking: false);
                return ListapedidosModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PaginatedList<ProductosModel> ObtenerTodosLosProductos(int pageCount)
        {
            try
            {
                var Pedidos = _repository.Get(tracking: false).ToList();
                return new PaginatedList<ProductosModel>
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
