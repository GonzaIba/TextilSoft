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
        public PaginatedList<ProductoGrillaEntity> ObtenerProductos(int pageIndex, int pageCount, Expression<Func<ProductoGrillaEntity, bool>> filterExpression, string orderBy, bool ascending);
        public PaginatedList<ProductoGrillaEntity> ObtenerListaProductos(int pageCount);

        public void EliminarProducto(int IdProducto);
        public void ModificarProducto(ProductosEntity producto);
        public void CrearProducto(ABMProductoEntity productosEntity);
        public void RegistrarProductoDefectuoso(int idProducto, int cantidad, string motivo);
    }
}
