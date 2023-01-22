using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contracts
{
    public partial interface IGenericService<T> where T : class
    {
        void Insertar(T entities);

        void Actualizar(T entities);

        void Eliminar(T entities);

        void Eliminar(List<T> entities);

        IEnumerable<T> ObtenerTodo();

        T ObtenerPorId(object id);

        T ObtenerPorFuncion(Expression<Func<T, bool>> func);

        void CancelarCambios(T entity);

        IEnumerable<T> Get(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "",
            bool ignoreQueryFilters = false,
            bool tracking = false);
    }
}
