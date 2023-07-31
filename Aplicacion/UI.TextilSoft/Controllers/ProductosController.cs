﻿using AutoMapper;
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
        private IArmadoProductoService _armadoProductoService;
        private IMapper _mapper;
        private ILogger _logger;
        public ProductosController(IProductoService productoService, IArmadoProductoService armadoProductoService, IMapper mapper, ILogger logger)
        {
            _productoService = productoService;
            _armadoProductoService = armadoProductoService;
            _mapper = mapper;
            _logger = logger;
        }
        
        public ProductosEntity ObtenerProducto(string codigo)
        {
            string guidPattern = @"^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$";

            bool isValidGuid = Regex.IsMatch(codigo, guidPattern);
            if (isValidGuid)
            {
                var ProductoDTO = _productoService.Get(x => x.CodigoProducto == Guid.Parse(codigo),includeProperties: "TipoPrenda,TelaBase,TelaCombinacion,BolsilloInterior,CinturaInterior,Collareta,Lazo,Vivo,Forreria").FirstOrDefault();
                var ProductoEntity = _mapper.Map<ProductosEntity>(ProductoDTO);
                return ProductoEntity;
            }
            return null;
        }

        public PaginatedList<ProductoGrillaEntity> ObtenerProductos(int pageIndex, int pageCount, Expression<Func<ProductoGrillaEntity, bool>> filterExpression, string orderBy, bool ascending)
        {
            try
            {
                Expression<Func<ProductosModel, dynamic>> orderByExpressionPedidosModel = orderBy switch
                {
                    "ID_Producto" => entity => entity.ID_Producto,
                    "CodigoProducto" => entity => entity.CodigoProducto.ToString(),
                    "Descripcion" => entity => entity.Descripcion,
                    "Precio" => entity => entity.Precio,
                    "TallePrenda" => entity => entity.TallePrenda,
                    "TipoPrenda" => entity => entity.TipoPrenda,
                    "Stock" => entity => entity.Stock,
                    _ => entity => entity.ID_Producto,
                };
                //var orderByExpressionProductosModel = orderByExpression.ReplaceParameter<ListarPedidosEntity, PedidosModel>();
                var filterExpressionProductosModel = filterExpression.ReplaceParameter<ProductoGrillaEntity, ProductosModel>();
                var ListaProductosModel = _productoService.ObtenerProductos(pageIndex, pageCount, orderByExpressionPedidosModel, filterExpressionProductosModel, orderBy, ascending);
                var ListaProductosEntity = new PaginatedList<ProductoGrillaEntity>();
                ListaProductosEntity.List = _mapper.Map<List<ProductoGrillaEntity>>(ListaProductosModel.List.ToList());
                ListaProductosEntity.TotalCount = ListaProductosModel.TotalCount;
                ListaProductosEntity.TotalPages = ListaProductosModel.TotalPages;
                //ListaPedidosModel.List.ToList().ForEach(listaPedidos => ListaPedidosEntity.List.ToList().Add(_mapper.Map<ListarPedidosEntity>(listaPedidos)));
                return ListaProductosEntity;
            }
            catch (Exception ex)
            {
                _logger.GenerateFatalLog("Ocurrió un error fatal al obtener los productos paginado", ex);
                throw ex;
            }
        }

        public PaginatedList<ProductoGrillaEntity> ObtenerListaProductos(int pageCount)
        {
            try
            {
                var ListaProductosModel = _productoService.ObtenerTodosLosProductos(pageCount);
                var ListaProductosEntity = new PaginatedList<ProductoGrillaEntity>();
                ListaProductosEntity.List = _mapper.Map<List<ProductoGrillaEntity>>(ListaProductosModel.List.ToList());
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

        public void CrearProducto(ABMProductoEntity productoEntity)
        {
            try
            {
                var ProductoDTO = _productoService.Get(x => x.Descripcion == productoEntity.Descripcion).FirstOrDefault();
                if (ProductoDTO != null)
                    throw new Exception("El producto ya existe");
                else
                {
                    var producto = _armadoProductoService.ObtenerCodigosDeArmados(productoEntity);                  
                    _productoService.Crear(producto);
                }
            }
            catch (Exception ex)
            {
                _logger.GenerateLogError("Ocurrió un error al crear el producto con el nombre: " + productoEntity.Descripcion, ex);
                throw ex;
            }
        }

        public void ModificarProducto(ProductosEntity productosEntity)
        {
            try
            {
                var ProductoDTO = _productoService.Get(x => x.Descripcion == productosEntity.NombreProducto, includeProperties: "TipoPrenda,TelaBase,TelaCombinacion,BolsilloInterior,Lazo,Vivo,Transfer").FirstOrDefault();
                if (ProductoDTO == null)
                {
                    var producto = _mapper.Map<ProductosModel>(productosEntity);
                    _productoService.Crear(producto);
                }
                else
                {
                    ProductoDTO.Descripcion = productosEntity.NombreProducto;
                    ProductoDTO.Precio = productosEntity.Precio;
                    ProductoDTO.TallePrenda = productosEntity.TallePrenda;
                    //ProductoDTO.TipoPrenda = productosEntity.TipoPrenda;
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
