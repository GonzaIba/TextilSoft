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
    public interface IPedidosFabricaService : IGenericService<PedidosFabricaModel>
    {
        public string CrearPedidoParaFabrica(int DNIEmpleado, List<DetallePedidosFabricaModel> detallePedidos);
        public PaginatedList<PedidosFabricaModel> ObtenerPedidos(int pageIndex, int pageCount, Expression<Func<PedidosFabricaModel, dynamic>> orderByExpression, Expression<Func<PedidosFabricaModel, bool>> filterExpression, string orderBy, bool ascending);
        public PaginatedList<PedidosFabricaModel> ObtenerTodosLosPedidos(int pageCount);
    }
}
