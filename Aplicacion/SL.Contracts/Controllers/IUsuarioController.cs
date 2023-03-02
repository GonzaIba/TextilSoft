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
    public interface IUsuarioController
    {
        bool Crearusuario(Register appIdentityUser, int companyId);
        bool ActualizarConfiguracionUsuario(UsuarioInformacion Usuarioinformacion);
        LoginResult LoginUser(Login appIdentityUser);
        //void UpdateUser(UsuarioModel appIdentityUser);
        //void DeleteUser(UsuarioModel appIdentityUser);
        UsuarioInformacion ObtenerInformacionUsuario(Usuario usuario);
        List<Usuario> ObtenerTodosLosUsuarioConPermisos();
        IList<Usuario> ObtenerUsuarios();
        IList<Familia> ObtenerFamilias();
        Usuario ObtenerUsuarioConPermisos(Login login);
        Usuario ObtenerUsuarioConPermisos(int DNI);
        Usuario ObtenerUsuario(Login login);
        void GuardarPermisos(Usuario usuario);
        string QuitarPermiso(Usuario usuario, Componente c);
        bool ExisteUsuario(string posibleUsuario);
        bool ExisteEmail(string posibleEmail);
        bool ExisteDNI(int posibleDNI);
        void EnviarConfirmacionEmail(string email);
        void RecuperarContraseña(string nombre, string email);
        bool CambiarContraseña((int id,string oldPassword, string newPassword) parametros);
        bool ValidarCodigoDeVerificacion(Usuario usuario,int numero);
    }
}
