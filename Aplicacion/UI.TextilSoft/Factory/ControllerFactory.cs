using Contracts.Controllers;
using iTextSharp.text.log;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SL.Contracts;
using SL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.TextilSoft.Factory
{
    public class ControllerFactory : IControllerFactory
    {
        private readonly IServiceProvider _serviceProvider;
        public ControllerFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        private readonly Dictionary<Type, object> _controllerDictionary = new Dictionary<Type, object>();

        public T Use<T>()
        {
            Type type = typeof(T);

            if (!_controllerDictionary.ContainsKey(type))
            {
                object controller = _serviceProvider.GetService(typeof(T));

                _controllerDictionary[type] = controller;
            }

            return (T)_controllerDictionary[type];
        }

        public T UseNew<T>()
        {
            Type type = typeof(T);
            var Object = (T)_serviceProvider.GetService(typeof(T)); //Creamos la instancia del nuevo servicio solicitado
            _controllerDictionary[type] = Object; //Agregamos el objeto por mas que no este en el diccionario
            return Object;
        }
         
        public void UpdateServices()
        {
            foreach (var service in _controllerDictionary)
            {
                var Object = _serviceProvider.GetService(service.Key);
                if(Object.GetType().Name != "Logger")
                    _controllerDictionary[service.Key] = Object;
            }
        }
    }
}
