using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
    public interface IProveedoresService : IGenericService<ProveedoresModel>
    {
        /// <summary>
        /// Creamos una factura 
        /// </summary>
        /// <param name="proveedoresEntity">Es el parametro de la capa de usuario</param>
        void CrearFactura(ProveedoresModel proveedoresEntity); 

        void Test(IEnumerable<ProveedoresModel> listita);

    }
}
