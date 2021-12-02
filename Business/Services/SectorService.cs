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
    public class SectorService : GenericService<SectorModel>, ISectorService
    {
        private readonly IMapper _mapper;
        public SectorService(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork, unitOfWork.GetRepository<ISectorRepository>())
        {
            _mapper = mapper;
        }

    }
}
