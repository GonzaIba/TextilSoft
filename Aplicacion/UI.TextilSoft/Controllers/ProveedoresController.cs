using AutoMapper;
using Contracts.Controllers;
using Contracts.Repositories;
using Contracts.Services;
using Domain.Entities;
using Domain.Models;
using SL.Helper.Services.Log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.TextilSoft.Controllers
{
    public class ProveedoresController : IProveedoresController
    {
        private IProveedoresService _proveedoresService;
        private IProductosProveedorService _productosProveedorService;
        private IMapper _mapper;
        public ProveedoresController(IProveedoresService proveedoresService, IMapper mapper, IProductosProveedorService productoProveedorController)
        {
            _proveedoresService = proveedoresService;
            _productosProveedorService = productoProveedorController;
            _mapper = mapper;
        }

        public void ActualizarProveedor(ProveedoresEntity proveedoresEntity)
        {
            //var resultado = _mapper.Map<ProveedoresModel>(proveedoresEntity);

            //var prueba = _proveedoresService.Get(x=>x.DNI == 123).FirstOrDefault();
            //proveedoresEntity.Mail = "kkkk";
            //proveedoresEntity.LugarEmpresa = "aloja";
            //var prueba2 = _proveedoresService.GetById(2025);
            //prueba2 = _mapper.Map<ProveedoresModel>(proveedoresEntity);
            //prueba2.LugarEmpresa = "jeddadje";
            //prueba2.Mail = "sadasd";
            //_proveedoresService.Actualizar(prueba2);

            //var prueba2 = _proveedoresService.GetByIdFunc(x=>x.DNI == proveedoresEntity.DNI);
            //////////////////var prueba2 = _proveedoresService.Get(x=>x.DNI == proveedoresEntity.DNI).FirstOrDefault();
            //////////////////prueba2.LugarEmpresa = "aaaads";
            //////////////////prueba2.Mail = "sadasda";
            //_proveedoresService.CrearFactura(prueba2);
            //////////////////_proveedoresService.Actualizar(prueba2);
        }

        public void CrearProveedor(ProveedoresEntity proveedoresEntity)
        {
            var ProveedorDTO = _mapper.Map<ProveedoresModel>(proveedoresEntity);
            //_proveedoresService.CrearFactura(resultado);
            _proveedoresService.Crear(ProveedorDTO);
            //ClientesModel clientesModel = new ClientesModel();
            //clientesModel.Apellido = "testunitofwork";
            //clientesModel.EstadoCliente = "Inactivo";
            //clientesModel.Mail = "testinguow";
            //clientesModel.FechaNac = DateTime.Now;
            //_clientesService.Insertar(clientesModel);
        }

        public void EliminarProveedor(ProveedoresEntity proveedoresEntity)
        {
            try
            {
                _proveedoresService.EliminarProveedor(proveedoresEntity);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public List<ProveedoresEntity> LlenarGrillaProveedores()
        {
            try
            {
                var ListaProveedoresDTO = _proveedoresService.GetAll();
                List<ProveedoresEntity> ListaProveedoresEntity = _mapper.Map<List<ProveedoresEntity>>(ListaProveedoresDTO);
                return ListaProveedoresEntity;
            }
            catch (Exception ex)
            {
                //Logger.GenerateInfo("Ocurrió un error en LlenarGrillaProveedores controller Proveedores, Excepción: " + ex.Message);
                throw ex;
            }
        }

        public void ActualizarProveedoresPorGrilla(List<ProveedoresEntity> listaProveedores)
        {
            try
            {
                foreach (var Proveedor in listaProveedores)
                {
                    var ProveedorDTO = _proveedoresService.Get(x => x.DNI == Proveedor.DNI).FirstOrDefault();
                    if (Proveedor == _mapper.Map<ProveedoresEntity>(ProveedorDTO) || ProveedorDTO == null)
                        break;
                    else
                    {
                        ProveedorDTO.FechaNac = Proveedor.FechaNac;
                        ProveedorDTO.Mail = Proveedor.Mail;
                        ProveedorDTO.Nombre = Proveedor.Nombre;
                        ProveedorDTO.LugarEmpresa = Proveedor.LugarEmpresa;
                        _proveedoresService.Actualizar(ProveedorDTO);
                    }
                }
            }
            catch (Exception ex)
            {
                //Logger.GenerateInfo("Ocurrió un error en ActualizarProveedoresPorGrilla controller Proveedores, Excepción: " + ex.Message);
                throw ex;
            }
        }

        public List<string> VerificarCambios(List<ProveedoresEntity> listaProveedores)
        {
            try
            {
                List<string> ListaCambios = new List<string>();
                foreach (var Proveedor in listaProveedores)
                {
                    var ProveedorDTO = _proveedoresService.Get(x => x.DNI == Proveedor.DNI, tracking: false).FirstOrDefault();
                    var ProveedorEntityMapeado = _mapper.Map<ProveedoresEntity>(ProveedorDTO);
                    if (!(Proveedor.DNI == ProveedorEntityMapeado.DNI && Proveedor.FechaNac == ProveedorEntityMapeado.FechaNac && Proveedor.LugarEmpresa == ProveedorEntityMapeado.LugarEmpresa && Proveedor.Nombre == ProveedorEntityMapeado.Nombre))
                    {
                        ListaCambios.Add($"El Proveedor con el DNI: {Proveedor.DNI}");
                    }
                }
                return ListaCambios;
            }
            catch (Exception ex)
            {
                //Logger.GenerateInfo("Ocurrió un error en VerificarCambios controller Proveedores, Excepción: " + ex.Message);
                throw ex;
            }
        }

        public List<ProveedoresEntity> DetectarCambios(List<ProveedoresEntity> listaProveedores)
        {
            try
            {
                List<ProveedoresEntity> listaProveedoresAcambiar = new List<ProveedoresEntity>();
                foreach (var Proveedor in listaProveedores)
                {
                    var ProveedorDTO = _proveedoresService.Get(x => x.DNI == Proveedor.DNI, tracking: false).FirstOrDefault();
                    var ProveedorEntityMapeado = _mapper.Map<ProveedoresEntity>(ProveedorDTO);
                    if (!(Proveedor.DNI == ProveedorEntityMapeado.DNI && Proveedor.FechaNac == ProveedorEntityMapeado.FechaNac && Proveedor.LugarEmpresa == ProveedorEntityMapeado.LugarEmpresa && Proveedor.Nombre == ProveedorEntityMapeado.Nombre && Proveedor.Mail == ProveedorEntityMapeado.Mail))
                        listaProveedoresAcambiar.Add(Proveedor);
                }
                return listaProveedoresAcambiar;
            }
            catch (Exception ex)
            {
                //Logger.GenerateInfo("Ocurrió un error en DetectarCambios controller Proveedores, Excepción: " + ex.Message);
                throw ex;
            }
        }

        public ProveedoresEntity ObtenerProveedor(string DNI)
        {
            try
            {
                var ProveedorDTO1 = _proveedoresService.Get(x => x.DNI == DNI).FirstOrDefault();
                var ProveedoresEntity = _mapper.Map<ProveedoresEntity>(ProveedorDTO1);
                return ProveedoresEntity;
            }
            catch (Exception ex)
            {
                //Logger.GenerateInfo("Ocurrió un error al obtener el proveedor, Excepción: "+ ex.Message);
                throw ex;
            }
        }
    }
}
