using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface IGenericRepository<T> : IDisposable where T : class
    {
        /// <summary>
        /// Inserta la clase especificada
        /// </summary>
        /// <param name="entities"></param>
        void Insert(T entities);

        /// <summary>
        /// Actualiza la clase especificada
        /// </summary>
        /// <param name="entities"></param>
        void Update(T entities);

        /// <summary>
        /// Elimina La clase especificada
        /// </summary>
        /// <param name="entities"></param>
        void Delete(T entities);

        /// <summary>
        /// En caso de que falle una operacion a la base de datos se llamaria a este metodo.
        /// Recomendacion: Utilizarlo en un try catch
        /// </summary>
        /// <param name="entity"></param>
        void CancelChanges(T entity);

        /// <summary>
        /// Busca la clase por el id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>La clase o null si no existe</returns>
        T GetById(object id);


        /// <summary>
        /// Devuelve una lista acorde al filtro y orden especificados. La ejecución del
        /// query sobre la base de datos depende de la acción que se realice sobre la lista.
        /// </summary>
        /// <param name="filter">Predicado para filtrar los registros</param>
        /// <param name="orderBy">Indica de qué manera se deben ordenar los registros</param>
        /// <param name="includeProperties">Propiedades a incluir, esto genera operaciones join con otras tablas</param>
        /// <param name="ignoreQueryFilters">Se usa para ignorar filtros por defecto en la configuración del DBContext</param>
        /// <returns>Un IEnumerable de elementos del tipo T</returns>
        /// 
        IEnumerable<T> Get(
        Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                string includeProperties = "",
                bool ignoreQueryFilters = false,
                bool tracking = true);


        /// <summary>
        /// Busca un registro acorde al filtro y orden especificados.
        /// </summary>
        /// <param name="filter">Predicado para filtrar los registros</param>
        /// <param name="orderBy">Indica de qué manera se deben ordenar los registros</param>
        /// <param name="includeProperties">Propiedades a incluir, esto genera operaciones join con otras tablas</param>
        /// <param name="ignoreQueryFilters">Se usa para ignorar filtros por defecto en la configuración del DBContext</param>
        /// <returns>El primer elemento que se encuentre, null si no hay resultados</returns>
        T GetOne(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "",
            bool ignoreQueryFilters = false);



        IQueryable<T> Table { get; }

        IQueryable<T> TableNoTracking { get; }


    }
}
