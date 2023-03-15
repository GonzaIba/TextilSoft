using Domain.GenericEntity;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
    public interface IPedidosService : IGenericService<PedidosModel>
    {
        public string CrearPedido(int DNICLiente, int DNIEmpleado, decimal subTotal, List<DetallePedidosModel> detallePedidos, decimal seña);
        public PaginatedList<PedidosModel> ObtenerPedidos(int pageIndex, int pageCount, Expression<Func<PedidosModel, dynamic>> orderByExpression, Expression<Func<PedidosModel, bool>> filterExpression, string orderBy, bool ascending);
        public PaginatedList<PedidosModel> ObtenerTodosLosPedidos(int pageCount);
        public int ObtenerUltimoNumeroPedido();
    }
}
