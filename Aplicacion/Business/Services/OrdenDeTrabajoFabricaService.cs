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
    public class OrdenDeTrabajoFabricaService : GenericService<OrdenDeTrabajoFabricaModel>, IOrdenDeTrabajoFabricaService
    {
        private readonly IMapper _mapper;
        public OrdenDeTrabajoFabricaService(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork, unitOfWork.GetRepository<IOrdenDeTrabajoFabricaRepository>())
        {
            _mapper = mapper;
        }

    }
}
