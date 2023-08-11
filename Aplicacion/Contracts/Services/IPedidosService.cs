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
        /// <summary>
        /// Recibe los datos del pedido y lo crea. Devuelve si se creó con exito
        /// </summary>
        /// <param name="DNICLiente"></param>
        /// <param name="DNIEmpleado"></param>
        /// <param name="subTotal"></param>
        /// <param name="detallePedidos"></param>
        /// <param name="seña"></param>
        /// <returns></returns>
        public string CrearPedido(int DNICLiente, int DNIEmpleado, decimal subTotal, List<DetallePedidosModel> detallePedidos, decimal seña);

        /// <summary>
        /// Se obtiene los pedidos paginado
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageCount"></param>
        /// <param name="orderByExpression"></param>
        /// <param name="filterExpression"></param>
        /// <param name="orderBy"></param>
        /// <param name="ascending"></param>
        /// <returns></returns>
        public PaginatedList<PedidosModel> ObtenerPedidos(int pageIndex, int pageCount, Expression<Func<PedidosModel, dynamic>> orderByExpression, Expression<Func<PedidosModel, bool>> filterExpression, string orderBy, bool ascending);

        /// <summary>
        /// Se obtienen todos los pedidos por cantidad de pagina
        /// </summary>
        /// <param name="pageCount"></param>
        /// <returns></returns>
        public PaginatedList<PedidosModel> ObtenerTodosLosPedidos(int pageCount);

        /// <summary>
        /// Se obtiene el ultimo pedido cargado en la base
        /// </summary>
        /// <returns></returns>
        public int ObtenerUltimoNumeroPedido();

        /// <summary>
        /// Se asigna una orden de trabajo
        /// </summary>
        /// <param name="idPedido"></param>
        public void AsignarODT(int idPedido);

        /// <summary>
        /// Se agrega la seña a un pedido
        /// </summary>
        /// <param name="idPedido"></param>
        /// <param name="seña"></param>
        public void AgregarSeña(int idPedido, decimal seña);
    }
}
