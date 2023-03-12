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
    public class PedidosFabricaService : GenericService<PedidosFabricaModel>, IPedidosFabricaService
    {
        private readonly IMapper _mapper;
        public PedidosFabricaService(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork, unitOfWork.GetRepository<IPedidosFabricaRepository>())
        {
            _mapper = mapper;
        }

    }
}
