using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.TextilSoft.Factory
{
    public interface IControllerFactory
    {
        T GetController<T>();
        T GetNewController<T>();
    }
}
