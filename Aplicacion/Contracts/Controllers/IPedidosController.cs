using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Controllers
{
    public interface IPedidosController
    {
        public List<ListarPedidosEntity> ObtenerPedidos(int pageIndex, int pageCount, Expression<Func<ListarPedidosEntity, bool>> filterExpression, string orderBy, bool ascending);
    }
}
