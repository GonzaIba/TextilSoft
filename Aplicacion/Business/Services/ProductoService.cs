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
    public class ProductoService : GenericService<ProductosModel>, IProductoService
    {
        private readonly IMapper _mapper;
        public ProductoService(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork, unitOfWork.GetRepository<IProductosRepository>())
        {
            _mapper = mapper;
        }

    }
}
