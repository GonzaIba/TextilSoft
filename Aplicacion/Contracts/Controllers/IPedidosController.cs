using Domain.Entities;
using Domain.GenericEntity;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Controllers
{
    public interface IPedidosController<T>
    {
        /// <summary>
        /// Obtiene un pedido paginado especificando la pagina, la cantidad de elementos y un filtro. T puede ser pedido de fabrica o para cliente
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageCount"></param>
        /// <param name="filterExpression"></param>
        /// <param name="orderBy"></param>
        /// <param name="ascending"></param>
        /// <param name="EsPedido"></param>
        /// <returns></returns>
        public PaginatedList<T> ObtenerPedidos(int pageIndex, int pageCount, Expression<Func<T, bool>> filterExpression, string orderBy, bool ascending, bool EsPedido);

        /// <summary>
        /// Obtiene pedidos en estado sin asignar paginado especificando la pagina, la cantidad de elementos y un filtro. T puede ser pedido de fabrica o para cliente
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageCount"></param>
        /// <param name="filterExpression"></param>
        /// <param name="orderBy"></param>
        /// <param name="ascending"></param>
        /// <param name="EsPedido"></param>
        /// <returns></returns>
        public PaginatedList<T> ObtenerPedidosParaODT(int pageIndex, int pageCount, string orderBy, bool ascending, bool EsPedido, bool EsParaCerrarODT = false);

        /// <summary>
        /// Devuelve un pedido listado a partir de un numero de pedido y un cliente especificado
        /// </summary>
        /// <param name="NumeroOrden"></param>
        /// <param name="clienteEntity"></param>
        /// <returns></returns>
        public ListarPedidosEntity ObtenerPedido(int NumeroOrden, ClientesEntity clienteEntity);

        /// <summary>
        /// Obtiene un pedido listado a partir de un numero de pedido y un cliente especificado. T puede ser pedido para cliente o de fabrica
        /// </summary>
        /// <param name="NumeroOrden"></param>
        /// <param name="clienteEntity"></param>
        /// <param name="EsPedido"></param>
        /// <returns></returns>
        public T ObtenerPedido(int NumeroOrden, ClientesEntity clienteEntity, bool EsPedido);

        /// <summary>
        /// Devuelve una lista de pedidos especificando el numero de pedido. T puede ser pedido para cliente o de fabrica
        /// </summary>
        /// <param name="pageCount"></param>
        /// <param name="EsPedido"></param>
        /// <returns></returns>
        public PaginatedList<T> ObtenerListaPedidos(int pageCount, bool EsPedido);

        /// <summary>
        /// Se cancela un pedido a partir de numero de orden y clientes entity
        /// </summary>
        /// <param name="NumeroOrden"></param>
        /// <param name="clienteEntity"></param>
        public void CancelarPedido(int NumeroOrden, ClientesEntity clienteEntity);

        /// <summary>
        /// Devuelve una lista de la cabezera detalle y el cliente asociado al pedido
        /// </summary>
        /// <param name="NumeroPedido"></param>
        /// <returns></returns>
        public (List<DetallePedidosYFabricaEntity>, ClientesEntity) ObtenerDetallePedido(int NumeroPedido);

        /// <summary>
        /// Genera un pedido y devuelve un resultado
        /// </summary>
        /// <param name="listaPedidos"></param>
        /// <param name="EsPedido"></param>
        /// <param name="DNIEmpleado"></param>
        /// <param name="DNICLiente"></param>
        /// <param name="totalPago"></param>
        /// <param name="seña"></param>
        /// <returns></returns>
        public string GenerarPedido(List<DetallePedidosYFabricaEntity> listaPedidos, bool EsPedido, int DNIEmpleado, int DNICLiente = 0, decimal totalPago = 0, decimal seña = 0);

        /// <summary>
        /// Asigna a ODT un pedido especificando el numero de pedido y el tipo de pedido
        /// </summary>
        /// <param name="idPedido"></param>
        /// <param name="EsPedido"></param>
        public void AsignarODT(int idPedido, bool EsPedido);

        /// <summary>
        /// Cierra la ODT
        /// </summary>
        /// <param name="idPedido"></param>
        /// <param name="EsPedido"></param>
        public void CerrarODT(int idPedido, bool EsPedido);

        /// <summary>
        /// Se agrega una seña a un pedido especificado
        /// </summary>
        /// <param name="idPedido"></param>
        /// <param name="seña"></param>
        public void AgregarSeña(int idPedido, decimal seña);
    }
}
