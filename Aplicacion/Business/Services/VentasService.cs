using AutoMapper;
using Contracts.Repositories;
using Contracts.Services;
using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class VentasService : GenericService<VentasModel>, IVentasService
    {
        private readonly IProductosRepository _productosRepository;
        private readonly IProductoDefectoRepository _productoDefectoRepository;
        public VentasService(IUnitOfWork unitOfWork)
            : base(unitOfWork, unitOfWork.GetRepository<IVentasRepository>())
        {
            _productosRepository = unitOfWork.GetRepository<IProductosRepository>();
            _productoDefectoRepository= unitOfWork.GetRepository<IProductoDefectoRepository>();
        }

        public VentasModel ObtenerCapitalEntreFechas(DateTime from, DateTime to)
        {
            try
            {
                var ventas = _repository.Get(x => x.CreateDate >= from && x.CreateDate <= to).ToList();
                VentasModel ventasModel = new();
                ventasModel = ventas.FirstOrDefault();
                ventasModel.TotalCapitalRecibido = ventas.Sum(x => x.TotalCapitalRecibido);
                return ventasModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProductoDefectoModel> ObtenerPrendasMasDefectuosas(DateTime from, DateTime to)
        {
            try
            {
                // Obtener las prendas más defectuosas desde la base de datos
                // Asegúrate de ajustar el método GetAll según cómo esté definido en tu repositorio
                var prendasDefectuosas = _productoDefectoRepository.Get();
                    //.GroupBy(x => x.Producto)
                    //.Select(g => new
                    //{
                    //    Producto = g.Key,
                    //    CantidadDefectuosa = g.Sum(x => x.Cantidad)
                    //})
                    //.OrderByDescending(x => x.CantidadDefectuosa)
                    //.ToList();
                
                return prendasDefectuosas.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<VentasModel> ObtenerPrendasMasVendidas(DateTime from, DateTime to)
        {
            try
            {
                var prendasMasVendidas = _repository
                    .Get(x => x.CreateDate >= from && x.CreateDate <= to, includeProperties: "Producto,Producto.TipoPrenda");
                    //.GroupBy(x => x.Producto.TipoPrenda)
                    //.Select(g => new
                    //{
                    //    TipoPrenda = g.Key,
                    //    CantidadVendida = g.Sum(x => x.Cantidad)
                    //})
                    //.OrderByDescending(x => x.CantidadVendida)
                    //.ToList();
                
                return prendasMasVendidas.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<VentasModel> ObtenerPrendasMenosVendidas(DateTime from, DateTime to)
        {
            try
            {
                var prendasMasVendidas = _repository
                    .Get(x => x.CreateDate >= from && x.CreateDate <= to, includeProperties: "Producto,Producto.TipoPrenda");
                    //.GroupBy(x => x.Producto.TipoPrenda)
                    //.Select(g => new
                    //{
                    //    TipoPrenda = g.Key,
                    //    CantidadVendida = g.Sum(x => x.Cantidad)
                    //})
                    //.OrderBy(x => x.CantidadVendida)
                    //.ToList();

                return prendasMasVendidas.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RegistrarVenta(VentasModel ventasModel)
        {
            var stock = _productosRepository.Get(x => x.ID_Producto == ventasModel.ID_Producto).FirstOrDefault().Stock;
            if (stock < ventasModel.Cantidad)
                throw new Exception("No hay stock suficiente");
            
            _repository.Insert(ventasModel);
            _unitOfWork.SaveChanges();
        }
    }
}
