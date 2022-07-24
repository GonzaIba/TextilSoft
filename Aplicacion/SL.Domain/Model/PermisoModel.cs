﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Model
{
    public class PermisoModel
    {
        public int Id_Permiso { get; set; }
        public int CompanyId { get; set; }
        public string Permiso { get; set; }
        public string Nombre { get; set; }

        public CompanyModel Company { get; set; }
        public ICollection<Usuario_PermisoModel> Usuario_Permisos { get; set; }
    }
}
