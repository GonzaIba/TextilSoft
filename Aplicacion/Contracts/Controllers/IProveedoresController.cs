using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Controllers
{
    public interface IProveedoresController
    {
        /// <summary>
        /// Se crea un proveedor
        /// </summary>
        /// <param name="proveedoresEntity"></param>
        void CrearProveedor(ProveedoresEntity proveedoresEntity);

        /// <summary>
        /// Se actualiza un proveedor
        /// </summary>
        /// <param name="proveedoresEntity"></param>
        void ActualizarProveedor(ProveedoresEntity proveedoresEntity);

        /// <summary>
        /// Se elimina un proveedor
        /// </summary>
        /// <param name="proveedoresEntity"></param>
        void EliminarProveedor(ProveedoresEntity proveedoresEntity);

        /// <summary>
        /// Se obtiene todos los proveedores
        /// </summary>
        /// <returns></returns>
        List<ProveedoresEntity> LlenarGrillaProveedores();

        /// <summary>
        /// Recibe una lista de proveedores y se actualizan
        /// </summary>
        /// <param name="listaProveedores"></param>
        void ActualizarProveedoresPorGrilla(List<ProveedoresEntity> listaProveedores);

        /// <summary>
        /// Se verifican cambios a traves de una lista de proveedores proporcionada
        /// </summary>
        /// <param name="listaProveedores"></param>
        /// <returns></returns>
        List<String> VerificarCambios(List<ProveedoresEntity> listaProveedores);

        /// <summary>
        /// Se detectan cambios a traves de una lista de proveedores proporcionada
        /// </summary>
        /// <param name="listaProveedores"></param>
        /// <returns></returns>
        List<ProveedoresEntity> DetectarCambios(List<ProveedoresEntity> listaProveedores);

        /// <summary>
        /// Se obtiene un proveedor a través de un DNI
        /// </summary>
        /// <param name="DNI"></param>
        /// <returns></returns>
        ProveedoresEntity ObtenerProveedor(string DNI);

    }
}
