using AutoMapper;
using SL.Contracts;
using SL.Contracts.Services;
using SL.Domain.Entities;
using SL.Domain.Enums;
using SL.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Helper.Controllers
{
    public class PermisosController : IPermisosController
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IUsuario_PermisoService _usuario_PermisoService;
        private readonly IPermisoService _permisoService;
        private readonly IPermiso_PermisoService _permiso_PermisoService;
        private readonly IMapper _mapper;

        public PermisosController(IUsuarioService usuarioService, IUsuario_PermisoService usuario_PermisoService, IPermisoService permisoService, IPermiso_PermisoService permiso_PermisoService, IMapper mapper)
        {
            _usuarioService = usuarioService;
            _usuario_PermisoService = usuario_PermisoService;
            _permisoService = permisoService;
            _permiso_PermisoService = permiso_PermisoService;
            _mapper = mapper;
        }

        public List<Patente> ObtenerPermisos()
        {
            var PermisosDto = _permisoService.ObtenerPermisos();
            List<Patente> Patentes = _mapper.Map<List<Patente>>(PermisosDto);
            //Removemos los permisos que no esten en el enum
            Patentes.RemoveAll(x => x.Permiso == TipoPermiso.SinPermisos || x.Permiso == TipoPermiso.EsFamilia);
            //IMPORTANTE: La idea es que los SinPermisos se puedan modificar en la interfaz del usuario (Los SinPermisos pueden traer conflictos)
            

            return Patentes;
        }

        public void CrearPermiso(Patente patente)
        {
            if(_permisoService.Get(x =>x.Nombre == patente.Nombre).Any())
                throw new Exception("El permiso ya existe");
            else if(String.IsNullOrEmpty(patente.Nombre))
                throw new Exception("El el permiso debe tener un nombre");

            var PermisoDto = _mapper.Map<PermisoModel>(patente);
            _permisoService.Insertar(PermisoDto);
        }

        public bool Existe(Componente c, int id)
        {
            bool existe = false;

            if (c.Id.Equals(id))
                existe = true;
            else
                foreach (var item in c.Hijos)
                {
                    existe = Existe(item, id);
                    if (existe) return true;
                }

            return existe;
        }

        public void GuardarFamilia(Familia c)
        {
            try
            {
                var PermisoPermiso = _mapper.Map<Permiso_PermisoModel>(c);
                var test = _permiso_PermisoService.Get(x => x.Id_Permiso_Padre == c.Id).ToList();
                _permiso_PermisoService.Eliminar(test);//Eliminamos todas las relaciones que tenia la familia

                var test2 = _permiso_PermisoService.Get(x => x.Id_Permiso_Padre == c.Id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
