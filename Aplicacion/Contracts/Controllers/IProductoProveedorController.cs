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
        List<ProductosProveedorEntity> LlenarGrillaProveedores();
        ProductosProveedorEntity ObtenerProdProveedor(string CodigoProd);
        void EliminarProveedor(ProductosProveedorEntity ProdproveedoresEntity);
        void ActualizarProdProveedoresPorGrilla(List<ProductosProveedorEntity> listaProdProveedores);
        List<String> VerificarCambios(List<ProductosProveedorEntity> listaProdProveedores);
        List<ProductosProveedorEntity> DetectarCambios(List<ProductosProveedorEntity> listaProdProveedores);
    }
}
