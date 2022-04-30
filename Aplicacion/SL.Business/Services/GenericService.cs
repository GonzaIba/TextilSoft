using SL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SL.Business
{
    public abstract class GenericService<T> : IGenericService<T> where T : class
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IGenericRepository<T> _repository;
        public GenericService(IUnitOfWork unitOfWork,
            IGenericRepository<T> repository)
        {
            this._unitOfWork = unitOfWork;
            this._repository = repository;
        }

        public virtual void Insertar(T entities)
        {
            _repository.Insert(entities);
            _unitOfWork.Save();
        }

        public void Actualizar(T entities)
        {
            _repository.Update(entities);
            _unitOfWork.Save();
        }

        public void CancelChanges(T entity)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(T entities)
        {
            _repository.Delete(entities);
            _unitOfWork.Save();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "", bool ignoreQueryFilters = false, bool tracking = false)
        {
            var result = _repository.Get(filter, orderBy, includeProperties, ignoreQueryFilters, tracking);
            return result;
        }


        public T GetById(object id)
        {
           return _repository.GetById(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _repository.TableNoTracking.AsEnumerable<T>().ToList();
        }

        public T GetByIdFunc(Expression<Func<T, bool>> func)
        {
            var result = _repository.Get(func).FirstOrDefault();

            return result;
        }

    }
}
