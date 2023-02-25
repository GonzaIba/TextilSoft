using Contracts.Controllers;
using Microsoft.Extensions.Configuration;
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

        public T GetController<T>()
        {
            Type type = typeof(T);

            if (!_controllerDictionary.ContainsKey(type))
            {
                object controller = _serviceProvider.GetService(typeof(T));

                _controllerDictionary[type] = controller;
            }

            return (T)_controllerDictionary[type];
        }

        public T GetNewController<T>()
        {
            return (T)_serviceProvider.GetService(typeof(T));
        }
    }
}
