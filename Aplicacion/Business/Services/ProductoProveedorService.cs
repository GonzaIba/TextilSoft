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
    public class ProductoProveedorService : GenericService<ProductosProveedorModel>, IProductosProveedorService
    {
        private readonly IMapper _mapper;
        public ProductoProveedorService(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork, unitOfWork.GetRepository<IProductosProveedorRepository>())
        {
            _mapper = mapper;
        }

    }
}
