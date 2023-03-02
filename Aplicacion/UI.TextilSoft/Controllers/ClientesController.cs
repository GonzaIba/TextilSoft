using AutoMapper;
using Contracts.Controllers;
using Contracts.Services;
using Domain.Entities;
using Domain.Models;
using SL.Helper.Services.Log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.TextilSoft.Controllers
{
    public class ClientesController : IClientesController
    {
        private readonly IClientesService _clientesService;
        private readonly IProveedoresController _proveedoresController;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;
        public ClientesController(IClientesService clientesService, IMapper mapper, IProveedoresController proveedoresController, ILogger logger)
        {
            _clientesService = clientesService;
            _proveedoresController = proveedoresController;
            _mapper = mapper;
            _logger = logger;
        }

        public void CrearCliente(ClientesEntity clientesEntity)
        {
            try
            {
                var ClienteModel = _mapper.Map<ClientesModel>(clientesEntity);
                ClienteModel.CreateDate = DateTime.Now;
                _clientesService.Insertar(ClienteModel);
                _logger.GenerateInfo($"Se creó el cliente: {clientesEntity.Nombre} {clientesEntity.Apellido} con el DNI: {clientesEntity.DNI}");
            }
            catch (Exception ex)
            {
                _logger.GenerateLogError(ex);
                throw;
            }

        }

        public List<ClientesEntity> LlenarGrillaClientes()
        {
            var result = _clientesService.GetAll();
            return null;
        }

        public ClientesEntity ObtenerCliente(string DNI)
        {
            var ClienteDTO = _clientesService.Get(x => x.DNI == DNI,tracking:false).FirstOrDefault();
            var Cliente = _mapper.Map<ClientesEntity>(ClienteDTO);
            return Cliente;
        }
    }
}
