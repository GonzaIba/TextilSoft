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
    public class VentasService : GenericService<VentasModel>, IVentasService
    {
        private readonly IMapper _mapper;
        public VentasService(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork, unitOfWork.GetRepository<IVentasRepository>())
        {
            _mapper = mapper;
        }

    }
}
