using AutoMapper;
using SL.Contracts;
using SL.Contracts.Services;
using SL.Domain.Entities;
using SL.Domain.Enums;
using SL.Domain.Model;
using SL.Helper.Configurations;
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
        private readonly CompanyConfiguration _companyConfiguration;
        
        public PermisosController(IUsuarioService usuarioService, IUsuario_PermisoService usuario_PermisoService, IPermisoService permisoService, IPermiso_PermisoService permiso_PermisoService, CompanyConfiguration companyConfiguration, IMapper mapper)
        {
            _usuarioService = usuarioService;
            _usuario_PermisoService = usuario_PermisoService;
            _permisoService = permisoService;
            _permiso_PermisoService = permiso_PermisoService;
            _companyConfiguration = companyConfiguration;
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

        public void CrearPermiso(Componente componente)
        {
            if(_permisoService.Get(x =>x.Nombre == componente.Nombre).Any())
                throw new Exception("El permiso ya existe");
            else if(String.IsNullOrEmpty(componente.Nombre))
                throw new Exception("El permiso debe tener un nombre");

            var PermisoDto = _mapper.Map<PermisoModel>(componente);
            PermisoDto.Permiso = PermisoDto.Permiso == TipoPermiso.EsFamilia.ToString() ? null : PermisoDto.Permiso;
            _permisoService.CrearPermiso(PermisoDto);
        }

        public bool Existe(Componente c, int id)
        {
            try
            {
                bool existe = false;

                if (c.Id.Equals(id))
                    existe = true;
                else
                {
                    FamiliaDependenciaCircular(c, id);
                    foreach (var item in c.Hijos)
                    {
                        existe = Existe(item, id);
                        if (existe) return true;
                    }
                }
                return existe;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        private void FamiliaDependenciaCircular(Componente f, int idPosiblePadre)
        {
            try
            {
                if (_permisoService.Get(x => x.Id_Permiso == f.Id && x.CompanyId == _companyConfiguration.CompanyId).FirstOrDefault()?.Permiso == null)
                {
                    if (_permiso_PermisoService.Get(x => x.Id_Permiso_Padre == idPosiblePadre && x.Id_Permiso_Hijo == f.Id).Any()) //No se que tan poco óptimo es esto...
                        throw new InvalidOperationException("Esta familia no puede ser la hija porque genera dependencias circulares");
                    else
                        foreach (var hijo in f.Hijos)
                            FamiliaDependenciaCircular(hijo, idPosiblePadre);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void GuardarFamilia(Familia c)
        {
            try
            {
                var permisoPadre = _mapper.Map<Permiso_PermisoModel>(c);
                List<Permiso_PermisoModel> Hijos = new List<Permiso_PermisoModel>();
                foreach (var hijo in c.Hijos)
                {
                    Permiso_PermisoModel PermisoPermiso = new Permiso_PermisoModel();
                    PermisoPermiso.Id_Permiso_Hijo = hijo.Id;
                    PermisoPermiso.Id_Permiso_Padre = c.Id;
                    Hijos.Add(PermisoPermiso);
                }
                _permiso_PermisoService.GuardarFamilia(permisoPadre, Hijos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GuardarPermisos(Usuario u)
        {
            try
            {
                var permisoPadre = _mapper.Map<Usuario_PermisoModel>(u);
                List<Usuario_PermisoModel> Hijos = new List<Usuario_PermisoModel>();
                foreach (var hijo in u.Permisos)
                {
                    Usuario_PermisoModel PermisoPermiso = new Usuario_PermisoModel();
                    PermisoPermiso.Id_Permiso = hijo.Id;
                    PermisoPermiso.Id_Usuario = u.Id;
                    Hijos.Add(PermisoPermiso);
                }
                _usuario_PermisoService.GuardarPermisos(permisoPadre, Hijos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarPermiso(Componente c)
        {
            try
            {
                //if (_permisoService.Get(x => x.Id_Permiso == c.Id).FirstOrDefault()?.Permiso == null)
                //{
                //    _permiso_PermisoService.EliminarPermiso(c.Id);
                //}
                //else
                //{
                //    _usuario_PermisoService.EliminarPermiso(c.Id);
                //}
                //_permisoService.Eliminar(c.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ValidarPermisosRepetidos(Familia familiaActual, Familia familiaAgregar)
        {
            try
            {
                bool EstaRepetido = false;
                foreach (var componente in familiaAgregar.Hijos)
                {
                    if(componente is Familia)
                        EstaRepetido = SepararFamilia(componente, familiaActual.Hijos.ToList());
                    else
                        EstaRepetido = BuscarPermiso(familiaActual.Hijos.ToList(), componente.Permiso);
                    if (EstaRepetido)
                        return true;
                }
         
                return EstaRepetido;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool SepararFamilia(Componente c, List<Componente> Permisos)
        {
            foreach (var patente in c.Hijos)
            {               
                return BuscarPermiso(Permisos, patente.Permiso);
            }
            return false;
        }


        private bool BuscarPermiso(List<Componente> Permisos, TipoPermiso tipoPermiso)
        {
            List<Patente> patentes = new List<Patente>();
            List<Familia> familias = new List<Familia>();
            patentes = Permisos.OfType<Patente>().ToList();
            familias = Permisos.OfType<Familia>().ToList();
            bool Result = false;
            Result = RecorrerPatentes(patentes, tipoPermiso);
            if (!Result)
                Result = RecorrerFamilias(familias, tipoPermiso);
            return Result;
        }

        private bool RecorrerFamilias(List<Familia> Listafamilias, TipoPermiso tipoPermiso)
        {
            bool Result = false;
            foreach (var Familias in Listafamilias)
            {
                foreach (var componente in Familias.Hijos)
                {
                    if (componente is Patente)
                        Result = RecorrerPatentes(new List<Patente>() { (Patente)componente }, tipoPermiso);
                    else
                        RecorrerFamilias(new List<Familia>() { (Familia)componente }, tipoPermiso);
                }
            }
            return Result;
        }

        private bool RecorrerPatentes(List<Patente> patentes, TipoPermiso tipoPermiso)
        {
            foreach (Patente patente in patentes)
            {
                if(patente.Permiso == tipoPermiso)
                    return true;
                
            }
            return false;
        }
    }
}
