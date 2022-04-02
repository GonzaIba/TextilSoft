using Contracts.Repositories;
using SL.Helper.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.UoW
{
    public class UnitOfWork : UnitOfWorkBase, IUnitOfWork
    {
        private List<Type> _repositories;

        public UnitOfWork(ApplicationDbContext context) : base(context)
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
                    //Acá hacemos lo siguiente:
                    //Primero utilizamos el metodo de la extensión que recibe el ensamblado, entonces con eso podemos recorrer todo el proyecto
                    //para obtener todos los types de las interfaces que implementen esta genérica (De tipo Repository)
                    //y sean interfaces(porque si obtenemos todo del ensamblado podria explotar si no hay una interfaz) 
            {
                var repository = this.GetType().Assembly.FindType(t => t.IsClass && iRepository.IsAssignableFrom(t));
                    //Luego aca recorremos todo el ensamblado del unit of work (que tiene el contexto, es decir, la instancia) para encontrar las
                    //clases que implementan esta interfaz y si es una clase
                _repositories.Add(repository);
            }
        }
    }
}
