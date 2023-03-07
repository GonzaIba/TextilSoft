using Domain.GenericEntity;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
    public interface IProductoService : IGenericService<ProductosModel>
    {
        public PaginatedList<ProductosModel> ObtenerProductos(int pageIndex, int pageCount, Expression<Func<ProductosModel, dynamic>> orderByExpression, Expression<Func<ProductosModel, bool>> filterExpression, string orderBy, bool ascending);
        public PaginatedList<ProductosModel> ObtenerTodosLosProductos(int pageCount);
    }
}
