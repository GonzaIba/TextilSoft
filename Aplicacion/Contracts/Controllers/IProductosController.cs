using Domain.Entities;
using Domain.GenericEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Controllers
{
    public interface IProductosController
    {
        public ProductosEntity ObtenerProducto(string codigo);
        public PaginatedList<ProductosEntity> ObtenerProductos(int pageIndex, int pageCount, Expression<Func<ProductosEntity, bool>> filterExpression, string orderBy, bool ascending);
        public PaginatedList<ProductosEntity> ObtenerListaProductos(int pageCount);

        public void EliminarProducto(int IdProducto);
        public void CrearProducto(ProductosEntity productosEntity);
    }
}
