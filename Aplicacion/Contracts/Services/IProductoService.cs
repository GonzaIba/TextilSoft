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
        /// <summary>
        /// Devuelve una lista de productos paginado a traves de la posicion de la pagina, la cantidad y el filtro
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageCount"></param>
        /// <param name="orderByExpression"></param>
        /// <param name="filterExpression"></param>
        /// <param name="orderBy"></param>
        /// <param name="ascending"></param>
        /// <returns></returns>
        public PaginatedList<ProductosModel> ObtenerProductos(int pageIndex, int pageCount, Expression<Func<ProductosModel, dynamic>> orderByExpression, Expression<Func<ProductosModel, bool>> filterExpression, string orderBy, bool ascending);

        /// <summary>
        /// Obtiene todos los productos de una pagina sin discriminar la cantidad
        /// </summary>
        /// <param name="pageCount"></param>
        /// <returns></returns>
        public PaginatedList<ProductosModel> ObtenerTodosLosProductos(int pageCount);
    }
}
