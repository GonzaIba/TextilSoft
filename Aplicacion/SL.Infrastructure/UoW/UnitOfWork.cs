using SL.Contracts;
using SL.Helper.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Infrastructure.UoW
{
    public class UnitOfWork : UnitOfWorkBase, IUnitOfWork
    {
        private List<Type> _repositories;

        public UnitOfWork(ServiceLayerDbContext context) : base(context)
        {
            InitializeRepositories();
        }

        public I GetRepository<I>()
        {
            var repository = _repositories.FirstOrDefault(t => typeof(I).IsAssignableFrom(t));
            return (I)Activator.CreateInstance(repository, Context);
        }

        private void InitializeRepositories()
        {
            _repositories = new List<Type>();
            var genericType = typeof(IGenericRepository<>).GetGenericTypeDefinition(); // Aca Obtenemos el Type de la interfaz genérica
            foreach (var iRepository in genericType.Assembly.GetTypes(t => t.IsInterface && t.ImplementsGenericInterface(genericType)))
            {
                var repository = this.GetType().Assembly.FindType(t => t.IsClass && iRepository.IsAssignableFrom(t));
                _repositories.Add(repository);
            }
        }
    }
}
