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
        public PaginatedList<T> ObtenerPedidos(int pageIndex, int pageCount, Expression<Func<T, bool>> filterExpression, string orderBy, bool ascending, bool EsPedido);
        public PaginatedList<T> ObtenerPedidosParaODT(int pageIndex, int pageCount, string orderBy, bool ascending, bool EsPedido);
        public ListarPedidosEntity ObtenerPedido(int NumeroOrden, ClientesEntity clienteEntity);
        public T ObtenerPedido(int NumeroOrden, ClientesEntity clienteEntity, bool EsPedido);
        public PaginatedList<T> ObtenerListaPedidos(int pageCount, bool EsPedido);
        
        public string GenerarPedido(List<DetallePedidosYFabricaEntity> listaPedidos, bool EsPedido, int DNIEmpleado, int DNICLiente = 0, decimal totalPago = 0, decimal seña = 0);
        public void AsignarODT(int idPedido, bool EsPedido);
    }
}
