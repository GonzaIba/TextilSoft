using AutoMapper;
using Business.Services;
using Contracts.Controllers;
using Contracts.Services;
using Domain.Entities;
using Domain.Enum;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.TextilSoft.Controllers
{
    public class VentasController : IVentasController
    {
        private readonly IMapper _mapper;
        private readonly IVentasService _ventasService;
        private readonly IProductoService _productoService;
        private readonly IEmpleadosService _empleadosService;
        
        public VentasController(IMapper mapper, IVentasService ventasService, IProductoService productoService, IEmpleadosService empleadosService)
        {
            _mapper = mapper;
            _ventasService = ventasService;
            _productoService = productoService;
            _empleadosService = empleadosService;
        }

        public void RegistrarVenta(VentasEntity ventasEntity, string DNI)
        {
            try
            {
                var ventasModel = _mapper.Map<VentasModel>(ventasEntity);
                var producto = _productoService.Get(x => x.CodigoProducto.ToString() == ventasEntity.CodigoProducto).FirstOrDefault();
                if( producto is null)
                {
                    throw new Exception("No existe un producto asociado");
                }
                ventasModel.ID_Producto = producto.ID_Producto;
                ventasModel.TotalCapitalRecibido = producto.Precio * ventasEntity.Cantidad;
                ventasModel.CreateUser = _empleadosService.Get(x => x.DNI == Convert.ToInt32(DNI)).FirstOrDefault().ID_Empleados;
                _ventasService.RegistrarVenta(ventasModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
