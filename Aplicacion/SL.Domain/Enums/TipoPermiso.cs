using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Enums
{
    public enum TipoPermiso
    {
        PuedeUsarPedidos,
        PuedeUsarVentas,
        PuedeUsarFacturas,
        PuedeUsarInformes,
        PuedeUsarProduccion,
        PuedeUsarProveedores,
        PuedeUsarConfiguracion,
        EsFamilia,
        SinPermisos
    }
}
