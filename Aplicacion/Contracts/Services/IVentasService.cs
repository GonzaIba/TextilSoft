using Domain.Entities;
using Domain.Enum;
using Domain.Models;
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
        
        public VentasModel ObtenerCapitalEntreFechas(DateTime from, DateTime to);
        public List<VentasModel> ObtenerPrendasMasVendidas (DateTime from, DateTime to);
        public List<VentasModel> ObtenerPrendasMenosVendidas(DateTime from, DateTime to);
        public List<ProductoDefectoModel> ObtenerPrendasMasDefectuosas(DateTime from, DateTime to);
    }
}
