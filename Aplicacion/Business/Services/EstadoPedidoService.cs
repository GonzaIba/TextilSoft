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
    public class EstadoPedidoService : GenericService<EstadoPedidoModel>, IEstadoPedidoService
    {
        public EstadoPedidoService(IUnitOfWork unitOfWork)
            : base(unitOfWork, unitOfWork.GetRepository<IEstadoPedidoRepository>())
        {
        }
    }
}
