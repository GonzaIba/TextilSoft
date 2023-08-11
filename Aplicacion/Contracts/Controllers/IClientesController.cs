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
        /// <summary>
        /// Crea un cliente
        /// </summary>
        /// <param name="clientesEntity"></param>
        void CrearCliente(ClientesEntity clientesEntity);

        /// <summary>
        /// Obtiene todos los clientes para utilizar en la vista
        /// </summary>
        /// <returns></returns>
        List<ClientesEntity> LlenarGrillaClientes();

        /// <summary>
        /// Devuelve un cliente por DNI
        /// </summary>
        /// <param name="DNI"></param>
        /// <returns></returns>
        ClientesEntity ObtenerCliente(string DNI);
    }
}
