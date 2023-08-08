﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
    public interface IVentasService : IGenericService<VentasModel>
    {
        public void RegistrarVenta(VentasModel ventasModel);
    }
}
