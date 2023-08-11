using AutoMapper;
using Contracts.Repositories;
using Contracts.Services;
using Domain.Enum;
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

        public void CrearFactura(FacturasModel factura, PedidosModel pedido)
        {
            try
            {
                _repository.Insert(factura);
                var PedidoRepository = _unitOfWork.GetRepository<IPedidosRepository>();

                pedido.ID_EstadoPedido = (int)EstadoPedidosEnum.Entregado;
                PedidoRepository.Update(pedido);

                _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
