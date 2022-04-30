using AutoMapper;
using SL.Contracts;
using SL.Contracts.Services;
using SL.Domain.Entities;
using SL.Domain.Enums;
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
            Patentes.RemoveAll(x => x.Permiso == TipoPermiso.SinPermisos);
            //IMPORTANTE: La idea es que los SinPermisos se puedan modificar en la interfaz del usuario (Los SinPermisos pueden traer conflictos)
            

            return Patentes;
        }
    }
}
