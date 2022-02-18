using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Controllers
{
    public interface IClientesController
    {
        void CrearCliente(ClientesEntity clientesEntity);

        List<ClientesEntity> LlenarGrillaClientes();

        ClientesEntity ObtenerCliente(string DNI);
    }
}
