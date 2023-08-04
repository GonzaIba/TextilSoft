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
        public dynamic ObtenerArmadoProductoPorTipo(ArmadoProductoEnum armadoProductoEnum);
        public dynamic ObtenerArmadoPorCodigo(ArmadoProductoEnum armadoProductoEnum, string code);
        public List<TransferEntity> ObtenerTransfer(string codigo = "");
        public void CrearTransfer(TransferEntity transfer);
    }
}
