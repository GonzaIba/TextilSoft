using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Controllers
{
    public interface IPedidosController
    {
        public List<PedidosEntity> ObtenerPedidos();

    }
}
