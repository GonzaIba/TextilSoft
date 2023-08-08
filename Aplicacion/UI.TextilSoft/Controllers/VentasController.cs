using AutoMapper;
using Contracts.Controllers;
using Contracts.Services;
using Domain.Entities;
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
        
        public VentasController(IVentasService ventasService, IProductoService productoService, IMapper mapper)
        {
            _ventasService = ventasService;
            _productoService = productoService;
            _mapper = mapper;
        }

        public void RegistrarVenta(VentasEntity ventasEntity)
        {
            try
            {
                var ventasModel = _mapper.Map<VentasModel>(ventasEntity);
                int idProducto = _productoService.Get(x => x.CodigoProducto.ToString() == ventasEntity.CodigoProducto).FirstOrDefault().ID_Producto;
                ventasModel.ID_Producto = idProducto;
                _ventasService.RegistrarVenta(ventasModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
