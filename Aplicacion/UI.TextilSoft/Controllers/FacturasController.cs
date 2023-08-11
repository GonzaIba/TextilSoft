using AutoMapper;
using Business.Services;
using Contracts.Controllers;
using Contracts.Services;
using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.TextilSoft.Controllers
{
    public class FacturasController : IFacturasController
    {
        private readonly IFacturasService _facturasService;
        private readonly IPedidosService _pedidosService;
        private readonly IClientesService _clientesService;
        private readonly IEmpleadosService _empleadosService;
        private readonly IMapper _mapper;
        public FacturasController(IFacturasService facturasService, IPedidosService pedidosService, IClientesService clientesService, IEmpleadosService empleadosService, IMapper mapper)
        {
            _facturasService = facturasService;
            _pedidosService = pedidosService;
            _clientesService = clientesService;
            _empleadosService = empleadosService;
            _mapper = mapper;
        }

        public void GenerarFactura(int NumeroPedido, string nota, int DNIEmpleado)
        {
            try
            {
                var pedidoModel = _pedidosService.Get(x => x.NumeroPedido == NumeroPedido).FirstOrDefault();
                if(pedidoModel == null)
                    throw new Exception("No se encontro el pedido");
                
                var empleadoModel = _empleadosService.Get(x => x.DNI == DNIEmpleado).FirstOrDefault();

                if (empleadoModel == null)
                    throw new Exception("El empleado no existe");
                
                FacturasModel facturasModel = new();
                facturasModel.Nota = nota;
                facturasModel.Pedidos = pedidoModel;
                facturasModel.TotalPago = pedidoModel.SubTotal - pedidoModel.Seña;
                facturasModel.Fecha = DateTime.Now;
                facturasModel.NumeroFactura = _facturasService.Get().Count() + 1;
                _facturasService.CrearFactura(facturasModel,pedidoModel);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
