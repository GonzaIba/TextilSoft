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
        public VentasService(IUnitOfWork unitOfWork)
            : base(unitOfWork, unitOfWork.GetRepository<IVentasRepository>())
        {
            _productosRepository = unitOfWork.GetRepository<IProductosRepository>();
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
