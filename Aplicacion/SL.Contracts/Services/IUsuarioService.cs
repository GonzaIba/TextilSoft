using Microsoft.AspNet.Identity.EntityFramework;
using SL.Domain.Entities;
using SL.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contracts
{
    public interface IUsuarioService : IGenericService<UsuarioModel>
    {
        string AccesResult(UsuarioModel usuarioModel,bool Result);
        string Login(Login usuarioModel);
        //string Register(UsuarioModel usuarioModel);
        //string Update(UsuarioModel usuarioModel);
        //string Delete(UsuarioModel usuarioModel);
        void GuardarPermisos(Usuario usuarioModel);
    }
}
