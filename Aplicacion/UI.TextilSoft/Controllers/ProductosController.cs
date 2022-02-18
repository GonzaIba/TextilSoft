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
    public class ProductosController : IProductosController
    {
        private IProductoService _productoService;
        private IMapper _mapper;
        public ProductosController(IProductoService productoService, IMapper mapper)
        {
            _productoService = productoService;
            _mapper = mapper;
        }

        public ProductoEntity ObtenerProducto(string codigo)
        {
            var ProductoDTO = _productoService.Get(x => x.CodigoProducto == codigo).FirstOrDefault();
            var ProductoEntity = _mapper.Map<ProductoEntity>(ProductoDTO);
            return ProductoEntity;
        }


    }
}
