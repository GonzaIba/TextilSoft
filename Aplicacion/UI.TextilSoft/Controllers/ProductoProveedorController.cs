using AutoMapper;
using Contracts.Controllers;
using Contracts.Services;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.TextilSoft.Controllers
{
    public class ProductoProveedorController : IProductoProveedorController
    {
        private IProveedoresService _proveedoresService;
        private IProductosProveedorService _productosProveedorService;
        private IMapper _mapper;
        public ProductoProveedorController(IProveedoresService proveedoresService, IMapper mapper, IProductosProveedorService productoProveedorController)
        {
            _proveedoresService = proveedoresService;
            _productosProveedorService = productoProveedorController;
            _mapper = mapper;
        }

        public void ActualizarProdProveedoresPorGrilla(List<ProductosProveedorEntity> listaProdProveedores)
        {
            foreach (var Prodproveedor in listaProdProveedores)
            {
                var ProdProveedorDTO = _productosProveedorService.Get(x => x.CodigoProducto == Prodproveedor.CodigoProducto).FirstOrDefault();
                if (Prodproveedor == _mapper.Map<ProductosProveedorEntity>(ProdProveedorDTO))
                {
                    // Si no hice ningun cambio no hago nada...
                }
                else
                {
                    //ProdProveedorDTO.FechaNac = Prodproveedor.FechaNac;
                    //ProdProveedorDTO.Mail = Prodproveedor.Mail;
                    //ProdProveedorDTO.Nombre = Prodproveedor.Nombre;
                    //ProdProveedorDTO.LugarEmpresa = Prodproveedor.LugarEmpresa;
                    //_proveedoresService.Actualizar(ProdProveedorDTO);/////////////
                }
            }
        }

        public void EliminarProveedor(ProductosProveedorEntity ProdProvEntity)
        {
            var ProdProvDTO = _productosProveedorService.Get(x => x.CodigoProducto == ProdProvEntity.CodigoProducto, includeProperties: "ProductoProveedor").FirstOrDefault();
            _productosProveedorService.Eliminar(ProdProvDTO);
        }

        public List<ProductosProveedorEntity> LlenarGrillaProveedores()
        {
            var ListaProdProveedoresDTO = _productosProveedorService.GetAll().ToList();
            List<ProductosProveedorEntity> ListaProdProveedoresEntity = _mapper.Map<List<ProductosProveedorEntity>>(ListaProdProveedoresDTO);
            return ListaProdProveedoresEntity;
        }

        public ProductosProveedorEntity ObtenerProdProveedor(string CodigoProd)
        {
            throw new NotImplementedException();
        }

        public List<string> VerificarCambios(List<ProductosProveedorEntity> listaProdProveedores)
        {
            List<string> ListaCambios = new List<string>();
            //foreach (var Prodproveedor in listaProdProveedores)
            //{
            //    var ProdProveedorDTO = _productosProveedorService.Get(x => x.CodigoProducto == Prodproveedor.DNI, tracking: false).FirstOrDefault();
            //    var ProveedorEntityMapeado = _mapper.Map<ProveedoresEntity>(ProdProveedorDTO);
            //    if (!(Proveedor.DNI == ProveedorEntityMapeado.DNI && Proveedor.FechaNac == ProveedorEntityMapeado.FechaNac && Proveedor.LugarEmpresa == ProveedorEntityMapeado.LugarEmpresa && Proveedor.Nombre == ProveedorEntityMapeado.Nombre))
            //    {
            //        ListaCambios.Add($"El Proveedor con el DNI: {Proveedor.DNI}");
            //    }
            //}
            return ListaCambios;
        }

        List<ProductosProveedorEntity> IProductoProveedorController.DetectarCambios(List<ProductosProveedorEntity> listaProdProveedores)
        {
            List<ProductosProveedorEntity> listaProveedoresAcambiar = new List<ProductosProveedorEntity>();
            //foreach (var ProdProveedor in listaProdProveedores)
            //{
            //    var ProdProveedorDTO = _proveedoresService.Get(x => x.DNI == ProdProveedor.DNI, tracking: false).FirstOrDefault();
            //    var ProdProvEntityMaped = _mapper.Map<ProductosProveedorEntity>(ProdProveedorDTO);
            //    if (!(Proveedor.DNI == ProdProveedorEntityMapeado.DNI && Proveedor.FechaNac == ProveedorEntityMapeado.FechaNac && Proveedor.LugarEmpresa == ProveedorEntityMapeado.LugarEmpresa && Proveedor.Nombre == ProveedorEntityMapeado.Nombre))
            //    {
            //        listaProveedoresAcambiar.Add(Proveedor);
            //    }
            //}
            return listaProveedoresAcambiar;
        }
    }
}
