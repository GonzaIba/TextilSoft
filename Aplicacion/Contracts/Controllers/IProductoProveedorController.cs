using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Controllers
{
    public interface IProductoProveedorController
    {
        /// <summary>
        /// Obtiene todos los proveedores
        /// </summary>
        /// <returns></returns>
        List<ProductosProveedorEntity> LlenarGrillaProveedores();

        /// <summary>
        /// Obtiene un proveedor por codigo
        /// </summary>
        /// <param name="CodigoProd"></param>
        /// <returns></returns>
        ProductosProveedorEntity ObtenerProdProveedor(string CodigoProd);

        /// <summary>
        /// Elimina un proveedor
        /// </summary>
        /// <param name="ProdproveedoresEntity"></param>
        void EliminarProveedor(ProductosProveedorEntity ProdproveedoresEntity);

        /// <summary>
        /// Recibe una lista de proveedores para actualizarlos
        /// </summary>
        /// <param name="listaProdProveedores"></param>
        void ActualizarProdProveedoresPorGrilla(List<ProductosProveedorEntity> listaProdProveedores);

        /// <summary>
        /// Recibe una lista y verifica si hay cambios. Devuelve los DNI
        /// </summary>
        /// <param name="listaProdProveedores"></param>
        /// <returns></returns>
        List<String> VerificarCambios(List<ProductosProveedorEntity> listaProdProveedores);

        /// <summary>
        /// Recibe una lista de proveedores y devuelve aquellos que se detectaron que se cambiaron
        /// </summary>
        /// <param name="listaProdProveedores"></param>
        /// <returns></returns>
        List<ProductosProveedorEntity> DetectarCambios(List<ProductosProveedorEntity> listaProdProveedores);
    }
}
