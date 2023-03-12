using AutoMapper;
using Business.Services;
using Contracts.Controllers;
using Contracts.Services;
using Domain.Entities;
using Domain.GenericEntity;
using Domain.Models;
using SL.Helper.Extensions;
using SL.Helper.Services.Log4net;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UI.TextilSoft.Controllers
{
    public class ProductosController : IProductosController
    {
        private IProductoService _productoService;
        private IMapper _mapper;
        private ILogger _logger;
        public ProductosController(IProductoService productoService, IMapper mapper, ILogger logger)
        {
            _productoService = productoService;
            _mapper = mapper;
            _logger = logger;
        }
        
        public ProductosEntity ObtenerProducto(string codigo)
        {
            string guidPattern = @"^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$";

            bool isValidGuid = Regex.IsMatch(codigo, guidPattern);
            if (isValidGuid)
            {
                var ProductoDTO = _productoService.Get(x => x.CodigoProducto == Guid.Parse(codigo)).FirstOrDefault();
                var ProductoEntity = _mapper.Map<ProductosEntity>(ProductoDTO);
                return ProductoEntity;
            }
            return null;
        }

        public PaginatedList<ProductosEntity> ObtenerProductos(int pageIndex, int pageCount, Expression<Func<ProductosEntity, bool>> filterExpression, string orderBy, bool ascending)
        {
            try
            {
                Expression<Func<ProductosModel, dynamic>> orderByExpressionPedidosModel = orderBy switch
                {
                    "ID_Producto" => entity => entity.ID_Producto,
                    "CodigoProducto" => entity => entity.CodigoProducto.ToString(),
                    "Color" => entity => entity.Color,
                    "Composicion" => entity => entity.Composicion,
                    "Estampa" => entity => entity.Estampa,
                    "NombreProducto" => entity => entity.NombreProducto,
                    "Precio" => entity => entity.Precio,
                    "Tejido" => entity => entity.Tejido,
                    "TallePrenda" => entity => entity.TallePrenda,
                    "TipoProducto" => entity => entity.TipoProducto,
                    "Stock" => entity => entity.Stock,
                    _ => entity => entity.ID_Producto,
                };
                //var orderByExpressionProductosModel = orderByExpression.ReplaceParameter<ListarPedidosEntity, PedidosModel>();
                var filterExpressionProductosModel = filterExpression.ReplaceParameter<ProductosEntity, ProductosModel>();
                var ListaProductosModel = _productoService.ObtenerProductos(pageIndex, pageCount, orderByExpressionPedidosModel, filterExpressionProductosModel, orderBy, ascending);
                var ListaProductosEntity = new PaginatedList<ProductosEntity>();
                ListaProductosEntity.List = _mapper.Map<List<ProductosEntity>>(ListaProductosModel.List.ToList());
                ListaProductosEntity.TotalCount = ListaProductosModel.TotalCount;
                ListaProductosEntity.TotalPages = ListaProductosModel.TotalPages;
                //ListaPedidosModel.List.ToList().ForEach(listaPedidos => ListaPedidosEntity.List.ToList().Add(_mapper.Map<ListarPedidosEntity>(listaPedidos)));
                return ListaProductosEntity;
            }
            catch (Exception ex)
            {
                _logger.GenerateFatalLog("Ocurrió un error fatal al obtener los productos paginado", ex);
                throw;
            }
        }

        public PaginatedList<ProductosEntity> ObtenerListaProductos(int pageCount)
        {
            try
            {
                var ListaProductosModel = _productoService.ObtenerTodosLosProductos(pageCount);
                var ListaProductosEntity = new PaginatedList<ProductosEntity>();
                ListaProductosEntity.List = _mapper.Map<List<ProductosEntity>>(ListaProductosModel.List.ToList());
                ListaProductosEntity.TotalCount = ListaProductosModel.TotalCount;
                ListaProductosEntity.TotalPages = ListaProductosModel.TotalPages;
                return ListaProductosEntity;
            }
            catch (Exception ex)
            {
                _logger.GenerateLogError("Ocurrió un error al obtener todos los productos", ex);
                throw ex;
            }
        }

        public void EliminarProducto(int IdProducto)
        {
            try
            {
                var ProductoDTO = _productoService.Get(x => x.ID_Producto == IdProducto).FirstOrDefault();
                if (ProductoDTO != null)
                    _productoService.Eliminar(ProductoDTO);
            }
            catch (Exception ex)
            {
                _logger.GenerateLogError("Ocurrió un error al eliminar el producto con el id: "+IdProducto, ex);
                throw ex;
            }

        }

        public void CrearProducto(ProductosEntity productosEntity)
        {
            try
            {
                var ProductoDTO = _productoService.Get(x => x.NombreProducto == productosEntity.NombreProducto).FirstOrDefault();
                if (ProductoDTO != null)
                {
                    throw new Exception("El producto ya existe");
                }
                else
                {
                    var producto = _mapper.Map<ProductosModel>(productosEntity);
                    //producto.CodigoProducto = null;
                    _productoService.Crear(producto);
                }
            }
            catch (Exception ex)
            {
                _logger.GenerateLogError("Ocurrió un error al crear el producto con el nombre: " + productosEntity.NombreProducto, ex);
                throw ex;
            }
        }

        public void ModificarProducto(ProductosEntity productosEntity)
        {
            try
            {
                var ProductoDTO = _productoService.Get(x => x.NombreProducto == productosEntity.NombreProducto).FirstOrDefault();
                if (ProductoDTO == null)
                {
                    var producto = _mapper.Map<ProductosModel>(productosEntity);
                    _productoService.Crear(producto);
                }
                else
                {
                    string color = _mapper.Map<ProductosModel>(productosEntity).Color;
                    ProductoDTO.Color = color;
                    ProductoDTO.Composicion = productosEntity.Composicion;
                    ProductoDTO.Estampa = productosEntity.Estampa;
                    ProductoDTO.NombreProducto = productosEntity.NombreProducto;
                    ProductoDTO.Precio = productosEntity.Precio;
                    ProductoDTO.TallePrenda = productosEntity.TallePrenda;
                    ProductoDTO.Tejido = productosEntity.Tejido;
                    ProductoDTO.TipoProducto = productosEntity.TipoProducto;
                    ProductoDTO.Stock = productosEntity.Stock;
                    _productoService.Actualizar(ProductoDTO);
                }
            }
            catch (Exception ex)
            {
                _logger.GenerateLogError("Ocurrió un error al crear el producto con el nombre: " + productosEntity.NombreProducto, ex);
                throw ex;
            }
        }
    }
}
