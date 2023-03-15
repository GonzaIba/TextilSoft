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
    public class DetallePedidosService : GenericService<DetallePedidosModel>, IDetallePedidosService
    {
        private readonly IMapper _mapper;
        public DetallePedidosService(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork, unitOfWork.GetRepository<IDetallePedidosRepository>())
        {
            _mapper = mapper;
        }

    }
}
