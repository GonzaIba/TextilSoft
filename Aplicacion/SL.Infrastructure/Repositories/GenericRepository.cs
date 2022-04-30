using Microsoft.EntityFrameworkCore;
using SL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SL.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        #region Fields

        internal ServiceLayerDbContext _context;
        internal DbSet<T> _entities;

        #endregion Fields

        #region Constructor

        public GenericRepository(ServiceLayerDbContext context)
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

        #endregion Properties

        #region Methods

        public virtual T GetById(object id)
        {
            return this.Entities.Find(id);
        }

        public void Insert(T entities)
        {
            this.Entities.Add(entities);
        }

        public void Update(T entities)
        {
            this._context.Entry(entities).State = EntityState.Modified;
        }

        public void Delete(T entities)
        {
            this._context.Entry(entities).State = EntityState.Deleted;
        }

        public virtual IEnumerable<T> Get(
                Expression<Func<T, bool>> filter = null,
                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                string includeProperties = "",
                bool ignoreQueryFilters = false,
                bool tracking = false)
        {
            IQueryable<T> query = tracking ? this.Entities : this.Entities.AsNoTracking();
            
            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (ignoreQueryFilters)
            {
                query = query.IgnoreQueryFilters();
            }

            foreach (string includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty.Trim());
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }
            else
            {
                return query;
            }
        }

        public T GetOne(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "",
            bool ignoreQueryFilters = false)
        {
            var result = Get(filter, orderBy, includeProperties, ignoreQueryFilters);
            return result.FirstOrDefault();
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

        #endregion Methods
    }
}
