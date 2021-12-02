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
    public class ClientesService : GenericService<ClientesModel>, IClientesService
    {
        private readonly IMapper _mapper;
        public ClientesService(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork, unitOfWork.GetRepository<IClientesRepository>())
        {
            _mapper = mapper;
        }

    }
}
