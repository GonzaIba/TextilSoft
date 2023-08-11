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
        /// <summary>
        /// Crea un pedido para la fabrica
        /// </summary>
        /// <param name="DNIEmpleado"></param>
        /// <param name="detallePedidos"></param>
        /// <returns></returns>
        public string CrearPedidoParaFabrica(int DNIEmpleado, List<DetallePedidosFabricaModel> detallePedidos);

        /// <summary>
        /// Se obtienen los pedidos paginados a traves de la posicion, la cantidad y el filtro si es necesario.
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageCount"></param>
        /// <param name="orderByExpression"></param>
        /// <param name="filterExpression"></param>
        /// <param name="orderBy"></param>
        /// <param name="ascending"></param>
        /// <returns></returns>
        public PaginatedList<PedidosFabricaModel> ObtenerPedidos(int pageIndex, int pageCount, Expression<Func<PedidosFabricaModel, dynamic>> orderByExpression, Expression<Func<PedidosFabricaModel, bool>> filterExpression, string orderBy, bool ascending);

        /// <summary>
        /// Se obtienen los pedidos a traves de una pagina
        /// </summary>
        /// <param name="pageCount"></param>
        /// <returns></returns>
        public PaginatedList<PedidosFabricaModel> ObtenerTodosLosPedidos(int pageCount);

        /// <summary>
        /// Se asigna una orden de trabajo al pedido de fabrica
        /// </summary>
        /// <param name="idPedido"></param>
        public void AsignarODT(int idPedido);
    }
}
