using Domain.Entities.ArmadoProductos;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Controllers
{
    public interface IArmadoProductoController
    {
        /// <summary>
        /// Devuelve una lista dinámica de armado de productos
        /// </summary>
        /// <param name="armadoProductoEnum"></param>
        /// <returns></returns>
        public dynamic ObtenerArmadoProductoPorTipo(ArmadoProductoEnum armadoProductoEnum);

        /// <summary>
        /// Devuelve un objeto dinámico por código y tipo de armado
        /// </summary>
        /// <param name="armadoProductoEnum"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public dynamic ObtenerArmadoPorCodigo(ArmadoProductoEnum armadoProductoEnum, string code);
        
        /// <summary>
        /// Devuelve una lista de transfer
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public List<TransferEntity> ObtenerTransfer(string codigo = "");

        /// <summary>
        /// Recibe un objeto transfer entity y lo crea
        /// </summary>
        /// <param name="transfer"></param>
        public void CrearTransfer(TransferEntity transfer);
    }
}
