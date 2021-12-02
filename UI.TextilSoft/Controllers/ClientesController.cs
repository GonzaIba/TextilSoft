using AutoMapper;
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
    public class ClientesController : IClientesController
    {
        private readonly IClientesService _clientesService;
        private readonly IMapper _mapper;
        public ClientesController(IClientesService clientesService, IMapper mapper)
        {
            _clientesService = clientesService;
            _mapper = mapper;
        }

        public void CrearCliente(ClientesEntity clientesEntity)
        {
            var ClienteModel = _mapper.Map<ClientesModel>(clientesEntity);
            _clientesService.Insertar(ClienteModel);
        }

        public List<ClientesEntity> LlenarGrillaClientes()
        {
            var result = _clientesService.GetAll();
            return null;
        }

        public ClientesEntity ObtenerCliente(int DNI)
        {
            var ClienteDTO = _clientesService.Get(x => x.DNI == DNI,tracking:false).FirstOrDefault();
            var Cliente = _mapper.Map<ClientesEntity>(ClienteDTO);
            return Cliente;
        }
    }
}
