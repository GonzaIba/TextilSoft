using AutoMapper;
using Contracts.Repositories;
using Contracts.Services;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ProductoDefectoService : GenericService<ProductoDefectoModel>, IProductoDefectoService
    {
        public ProductoDefectoService(IUnitOfWork unitOfWork)
            : base(unitOfWork, unitOfWork.GetRepository<IProductoDefectoRepository>())
        {
            
        }

    }
}
