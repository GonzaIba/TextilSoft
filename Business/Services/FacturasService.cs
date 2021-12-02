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
    public class FacturasService : GenericService<FacturasModel>, IFacturasService
    {
        private readonly IMapper _mapper;
        public FacturasService(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork, unitOfWork.GetRepository<IFacturasRepository>())
        {
            _mapper = mapper;
        }

    }
}
