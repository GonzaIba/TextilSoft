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
    public class TransferService : GenericService<TransferModel>, ITransferService
    {
        private readonly IMapper _mapper;
        public TransferService(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork, unitOfWork.GetRepository<ITransferRepository>())
        {
            _mapper = mapper;
        }
    }
}
