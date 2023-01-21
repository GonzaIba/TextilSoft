using SL.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Entities
{
    public class Usuario
    {
        public Usuario()
        {
            _permisos = new List<Componente>();
        }

        List<Componente> _permisos;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string DNI { get; set; }
        public bool IsAdmin { get; set; }

        public List<Componente> Permisos
        {
            get
            {
                return _permisos;
            }
        }
        
        public bool BuscarPermiso(TipoPermiso tipoPermiso)
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
                if (patente.Permiso == tipoPermiso)
                    return true;
            }
            return false;
        }
    }
}
