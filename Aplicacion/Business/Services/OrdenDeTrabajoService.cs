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
    class OrdenDeTrabajoService : GenericService<OrdenDeTrabajoModel>, IOrdenDeTrabajoService
    {
        private readonly IMapper _mapper;
        public OrdenDeTrabajoService(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork, unitOfWork.GetRepository<IOrdenDeTrabajoRepository>())
        {
            _mapper = mapper;
        }

    }
}
