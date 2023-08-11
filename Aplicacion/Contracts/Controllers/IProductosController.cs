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
        /// <summary>
        /// Obtiene un producto a través de un código
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public ProductosEntity ObtenerProducto(string codigo);

        /// <summary>
        /// Devuelve una lista de productos con un paginado y un filtro.
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageCount"></param>
        /// <param name="filterExpression"></param>
        /// <param name="orderBy"></param>
        /// <param name="ascending"></param>
        /// <returns></returns>
        public PaginatedList<ProductoGrillaEntity> ObtenerProductos(int pageIndex, int pageCount, Expression<Func<ProductoGrillaEntity, bool>> filterExpression, string orderBy, bool ascending);
        public PaginatedList<ProductoGrillaEntity> ObtenerListaProductos(int pageCount);

        /// <summary>
        /// Elimina un producto
        /// </summary>
        /// <param name="IdProducto"></param>
        public void EliminarProducto(int IdProducto);

        /// <summary>
        /// Modifica un producto a través de un objeto
        /// </summary>
        /// <param name="producto"></param>
        public void ModificarProducto(ProductosEntity producto);

        /// <summary>
        /// Se crea un producto a través de un objeto
        /// </summary>
        /// <param name="productosEntity"></param>
        public void CrearProducto(ABMProductoEntity productosEntity);

        /// <summary>
        /// Se registra un producto defectuoso.
        /// </summary>
        /// <param name="idProducto"></param>
        /// <param name="cantidad"></param>
        /// <param name="motivo"></param>
        /// <param name="DNIEmpleado"></param>
        public void RegistrarProductoDefectuoso(int idProducto, int cantidad, string motivo, int DNIEmpleado);
    }
}
