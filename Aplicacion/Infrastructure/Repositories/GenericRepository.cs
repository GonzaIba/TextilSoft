using Contracts.Entities;
using Contracts.Repositories;
using Domain.Enum;
using Domain.GenericEntity;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IGenericEntity
    {
        #region Fields
        internal ApplicationDbContext _context;
        internal DbSet<T> _entities;
        #endregion Fields

        #region Constructor
        public GenericRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        #endregion Constructor

        #region Properties
        public virtual IQueryable<T> Table => this.Entities;

        public virtual IQueryable<T> TableNoTracking => this.Entities.AsNoTracking();

        protected virtual DbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _context.Set<T>();
                }
                return _entities;
            }
        }
        
        //public EmpleadosEntity UsuarioLogueado
        //{
        //    get
        //    {
        //        return this.UsuarioLogueado;
        //    }
        //    set
        //    {
        //        this.UsuarioLogueado = value;
        //    }
        //}

        #endregion Properties

        #region Methods
        public virtual T GetById(object entity)
        {
            return this.Entities.Find(entity);
        }

        public void Insert(T entities)
        {
            entities.CreateDate = DateTime.Now;
            this.Entities.Add(entities);
        }
        
        public void Update(T entities)
        {
            //var result = Get(x => x == entities).FirstOrDefault();
            //var result3 = Get(x => x == entities).FirstOrDefault();

            //this._context.Entry(result).State = EntityState.Detached;
            //result = result3;

            ////if the entity dont have the property UpdateDate, dont set
            //if (entities.GetType().GetProperty("UpdateDate") != null)
            //{
            //    entities.UpdateDate = DateTime.Now;
            //}


            entities.UpdateDate = DateTime.Now;
            this._context.Entry(entities).State = EntityState.Modified;
        }

        public void Delete(T entities)
        {
            if (entities.GetType().GetProperty("Active") != null)
            {
                entities.Active = false;
                this._context.Entry(entities).State = EntityState.Modified;
            }
            else
                this._context.Entry(entities).State = EntityState.Deleted; // Puede ser una tabla intermedia..

        }

        public virtual IEnumerable<T> Get(
                Expression<Func<T, bool>> filter = null,
                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                string includeProperties = "",
                bool ignoreQueryFilters = false,
                bool tracking = false)
        {
            IQueryable<T> query = tracking ? this.Entities : this.Entities.AsNoTracking();
            
            if (ignoreQueryFilters)
                query = query.IgnoreQueryFilters();

            if (filter != null)
                query = query.Where(filter);


            switch (CheckIncludeEnum(includeProperties))
            {
                case IncludeEnum.None:
                    break;
                case IncludeEnum.All:
                    var navigations = _context.Model.FindEntityType(typeof(T))
                                                    .GetDerivedTypesInclusive()
                                                    .SelectMany(type => type.GetNavigations())
                                                    .Distinct();

                    foreach (var property in navigations)
                    {
                        query = query.Include(property.Name);
                    }

                    break;
                case IncludeEnum.Personalized:
                    foreach (string includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                             query = query.Include(includeProperty.Trim());
                    break;
            }




            if (orderBy != null)
                return orderBy(query);
            else
                return query;
        }

        public T GetOne
            (
                Expression<Func<T, bool>> filter = null,
                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                string includeProperties = "",
                bool ignoreQueryFilters = false
            )
        {
            var result = Get(filter, orderBy, includeProperties, ignoreQueryFilters);
            return result.FirstOrDefault();
        }

        public virtual IEnumerable<T> GetDeleted(string includeProperties = "")
        {
            var result = Get(x => x.Active == false, null,includeProperties);
            return result;
        }

        public virtual PaginatedList<T> GetPagedElements<S>(int pageIndex, int pageCount,
            Expression<Func<T, S>> orderByExpression, bool ascending,
            Expression<Func<T, bool>> filter = null, string includeProperties = "", bool tracking = false)
        {
            //Verificar los argumentos para esta consulta
            if (pageIndex < 0)
            {
                throw new ArgumentException(
                    //Resources.Messages.exception_InvalidPageIndex,
                    "pageIndex");
            }

            if (pageCount <= 0)
            {
                throw new ArgumentException(
                    //Resources.Messages.exception_InvalidPageCount,
                    "pageCount");
            }

            if (orderByExpression == null)
            {
                throw new ArgumentNullException(nameof(orderByExpression)
                        //, Resources.Messages.exception_OrderByExpressionCannotBeNull
                        );
            }

            IQueryable<T> query = tracking ? this.Entities : this.Entities.AsNoTracking();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (!String.IsNullOrEmpty(includeProperties))
            {
                foreach (string includeProperty in includeProperties.Split
                    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            return new PaginatedList<T>
            {
                TotalCount = query.Count(),
                TotalPages = (int)Math.Ceiling(query.Count() / (double)pageCount),
                List = (ascending)
                            ?
                        query.OrderBy(orderByExpression)
                            .Skip((pageIndex - 1) * pageCount)
                            .Take(pageCount)
                            :
                        query.OrderByDescending(orderByExpression)
                            .Skip((pageIndex - 1) * pageCount)
                            .Take(pageCount)
            };
        }

        public virtual void CancelChanges(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            this._context.Entry(entity).State = EntityState.Unchanged;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        //public void SetUserLogin(EmpleadosModel empleadoLogin)
        //{
        //    UsuarioLogueado = empleadoLogin;
        //}

        #endregion Methods


        #region Helpers

        private IncludeEnum CheckIncludeEnum(string includeProperties)
        {
            if(includeProperties == "")
                return IncludeEnum.None;
            else if(includeProperties == "All")
                return IncludeEnum.All;
            else
                return IncludeEnum.Personalized;
        }

        #endregion
    }
}
