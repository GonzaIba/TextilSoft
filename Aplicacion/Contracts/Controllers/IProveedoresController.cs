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

        void CrearProveedor(ProveedoresEntity proveedoresEntity);

        void ActualizarProveedor(ProveedoresEntity proveedoresEntity);

        void EliminarProveedor(ProveedoresEntity proveedoresEntity);

        List<ProveedoresEntity> LlenarGrillaProveedores();

        void ActualizarProveedoresPorGrilla(List<ProveedoresEntity> listaProveedores);

        List<String> VerificarCambios(List<ProveedoresEntity> listaProveedores);

        List<ProveedoresEntity> DetectarCambios(List<ProveedoresEntity> listaProveedores);

        ProveedoresEntity ObtenerProveedor(string DNI);

    }
}
